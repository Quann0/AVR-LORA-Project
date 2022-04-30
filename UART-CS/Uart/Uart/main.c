/*
 * Uart.c
 *
 * Created: 4/27/2022 8:01:59 PM
 * Author : QUAN
 */ 
#define F_CPU 8000000UL
#include <avr/io.h>
#include <avr/interrupt.h>
#include <util/delay.h>
#include <string.h>
#include <stdlib.h>
//char data[4];
char data[2];
const char *fixbug = "0";
void uart_char_tx(unsigned char chr) 
{
	while (bit_is_clear(UCSR0A,UDRE0)) { };
	UDR0=chr;
}
void uart1_char_tx(char chr)
{
	while (bit_is_clear(UCSR1A,UDRE1)) { };
	UDR1=chr;
}
void gui_1_chuoi_dulieu( char a[2])
{
	if(strlen(a)==1)
	{
		a[1] = a[0];
		a[0] = *fixbug;
	}
	for(int i=0;i<strlen(a);i++)
	{
		uart1_char_tx(a[i]);
	}
}
uint16_t read_adc(unsigned int adc_channel) //adc_channel l?u tham s? kênh ADC c?n ??c.
{
	ADMUX |= adc_channel; //Ch?n kênh ADC.
	ADCSRA |=(1<<ADSC); //Cho phép b?t ??u quá tr?nh chuy?n ??i ADC: l?y giá tr? ?i?n áp vào (Vin) trên kênh ?? ch?n, sau ?ó th?c hi?n chuy?n ??i ADC theo công th?c:
	while(bit_is_clear(ADCSRA,ADIF)) //trong khi th?c hi?n chuy?n ??i ADC (bit ADIF = 0).
	{
		; //Ch? trong quá tr?nh chuy?n ??i ADC, sau khi chuy?n ??i xong th? bit ADIF = 1.
	}
	_delay_ms(50);
	//Ho?c có th? s? d?ng l?nh loop nh? sau ?? thay th? cho l?nh while bên trên:
	//	loop_until_bit_is_set(ADCSRA,ADIF);
	return ADCW; //Giá tr? chuy?n ??i ???c l?u vào thanh ghi ADCW 16 bit.
}
void led7seg(uint16_t ADC_val) {
	uint16_t nghin,tram,chuc,donvi;
	donvi = ADC_val % 10; //L?y giá tr? ADC chia cho 10 l?y ph?n d? gán vào bi?n donvi.
	ADC_val /= 10; //L?y giá tr? ADC chia cho 10 l?y ph?n nguyên gán vào bi?n ADC_val
	chuc = ADC_val % 10;
	ADC_val /= 10;
	tram = ADC_val % 10;
	ADC_val /= 10;
	nghin = ADC_val;
	PORTA = nghin|(1<<PA4);//(1<<PE4):c?p ngu?n cho led hàng ngh?n sau ?ó OR v?i nghin.
	_delay_ms(1);
	PORTA = tram|(1<<PA5); //(1<<PE5):c?p ngu?n cho led hàng tr?m sau ?ó OR v?i tram.
	_delay_ms(1);
	PORTA = chuc|(1<<PA6);//(1<<PE6):c?p ngu?n cho led hàng ch?c sau ?ó OR v?i chuc.
	_delay_ms(1);
	PORTA = donvi|(1<<PA7);//(1<<PE7):c?p ngu?n cho led hàng ??n v? sau ?ó OR v?i donvi.
	_delay_ms(1);
}
volatile unsigned char u_data;
int main(void){

	//Baudrate 9600, t?n s? f=8MHz
	DDRA = 0xFF;
	DDRB = 0xff;
	UBRR0H=0;
	UBRR0L=51;
	UBRR1H=0;
	UBRR1L=51;
	UCSR0A=0x00;
	UCSR0C =(1<<UCSZ01)|(1<<UCSZ00);
	UCSR0B =(1<<RXEN0)|(1<<TXEN0)|(1<<RXCIE0); //cho phép truy?n nh?n d? li?u và cho phép ng?t nh?n
	UCSR1A=0x00;
	UCSR1C =(1<<UCSZ11)|(1<<UCSZ10);
	UCSR1B |=(1<<TXEN1)|(1<<TXCIE1);
	ADMUX |= (1<<REFS0); //Ch?n ?i?n áp tham chi?u AVCC
	ADCSRA |=(1<<ADEN) | (1<<ADPS2) | (1<<ADPS0);//Cho phép ADC và ch?n h? s? chia xung nh?p cho ADC là 32.
	sei(); //cho phép ng?t toàn c?c (bit I
    /* Replace with your application code */
	uint16_t nhietdo=0;
    while (1) 
    {
		nhietdo = read_adc(0);
		nhietdo = nhietdo*5/10.23;
		led7seg(nhietdo);
		itoa(nhietdo,data,10);//convert s? có cõ s? 10->chu?i
		gui_1_chuoi_dulieu(data);	
    }
}

ISR(USART0_RX_vect) { //hàm ph?c v? ng?t nh?n c?a UART0 thay cho hàm ISR(SIG_UART0_RECV)
	u_data=UDR0;
	if(u_data =='1')
	{
		PORTB |= (1<<PB0);
	}
	else if(u_data =='2')
	{
		PORTB &= ~(1<<PB0);
	}
	uart_char_tx(u_data);
}