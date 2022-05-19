/*
 * Uart.c
 *
 * Created: 4/27/2022 8:01:59 PM
 * Author : QUAN
 */ 


#define F_CPU 8000000UL
#include <stdio.h>
#include <avr/io.h>
//#include <stdio.h>
#include <avr/interrupt.h>
#include <util/delay.h>
#include <string.h>
#include <stdlib.h>

#ifndef DHT11_H_
#define DHT11_H_

#define DHT11_ERROR 255
#define DHT11_DDR DDRF
#define DHT11_PORT PORTF
#define DHT11_PIN PINF
#define DHT11_INPUTPIN PF1

#endif /* DHT11_H_ */

void dht11_getdata(uint8_t num, uint8_t *data);
uint8_t getdata(uint8_t select);
char dataSend[4];
uint8_t datatemp = 0;
uint8_t dataHumi = 0;
uint16_t DataSum = 0;
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
void gui_1_chuoi_dulieu( char a[4])
{
	for(int i=0;i<strlen(a);i++)
	{
		uart1_char_tx(a[i]);
	}
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
void TMR_vInit(void)
{
	/* Start timer 1 with clock prescaler CLK/1024 */
	/* Resolution is 139 us */
	/* Maximum time is 9.1 s */
	TCCR1A = (0<<COM1A1)|(0<<COM1A0)|(0<<COM1B1)|(0<<COM1B0)|(0<<COM1C1)|(0<<COM1C0)|(0<<WGM11)|(0<<WGM10);

	TCCR1B = (0<<ICNC1)|(0<<ICES1)|(0<<WGM13)|(0<<WGM12)|(1<<CS12)|(0<<CS11)|(1<<CS10);
}
volatile unsigned char u_data;
int main(void){
	TMR_vInit();	
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
	UCSR1B =(1<<RXEN1)|(1<<TXEN1)|(1<<RXCIE1);
	
	TCCR1A |=(1<<CS11)|(1<<CS10); // CS12=0, CS11=1, CS10=1(chia t?n s? cho 64)
	OCR1A = 0xF0;
	TIMSK |=(1<<OCIE1A); //cho phép ng?t tràn c?a T/C1
	sei(); //cho phép ng?t toàn c?c (bit I
    /* Replace with your application code */
//	char buf[40] = {0,};
    while (1) 
    {
    }
}

ISR(USART0_RX_vect) { //hàm ph?c v? ng?t nh?n c?a UART0 thay cho hàm ISR(SIG_UART0_RECV)
	u_data=UDR0;
	if(u_data =='1')
	{
		PORTB &= ~(1<<PB0);
	}
	else if(u_data =='2')
	{
		PORTB |= (1<<PB0);
	}
	else if(u_data =='3')
	{
		PORTB &= ~(1<<PB0);
	}
	else if(u_data =='4')
	{
		PORTB &= ~(1<<PB0);
	}
	uart_char_tx(u_data);
}
ISR (TIMER1_COMPA_vect){
	dht11_getdata(0, &datatemp);
	dht11_getdata(1, &dataHumi);
	DataSum=datatemp*100+dataHumi;
	led7seg(DataSum);
	_delay_ms(100);
	dataSend[0] = datatemp;
	dataSend[1] = dataHumi;
	//itoa(DataSum,dataSend,10);
	gui_1_chuoi_dulieu(dataSend);
}
/* get data from dht11 */
uint8_t getdata(uint8_t select) {
	uint8_t bits[5];
	uint8_t i,j = 0;
	
	memset(bits, 0, sizeof(bits));
	
	//reset port
	DHT11_DDR |= (1<<DHT11_INPUTPIN); //output
	DHT11_PORT |= (1<<DHT11_INPUTPIN); //high
	_delay_ms(100);
	
	//send request
	DHT11_PORT &= ~(1<<DHT11_INPUTPIN); //low
	_delay_ms(18);
	//-- MCU pulls up voltage and waits for DHT response (20-40us)
	DHT11_PORT |= (1<<DHT11_INPUTPIN); //high
	_delay_us(1);
	DHT11_DDR &= ~(1<<DHT11_INPUTPIN); //input
	_delay_us(39);
	//--
	
	//check start condition 1 (low)
	if((DHT11_PIN & (1<<DHT11_INPUTPIN))) {
		return DHT11_ERROR;
	}
	_delay_us(80);
	//check start condition 2 (high)
	if(!(DHT11_PIN & (1<<DHT11_INPUTPIN))) {
		return DHT11_ERROR;
	}
	_delay_us(80);
	
	//read the data
	for (j=0; j<5; j++) { //read 5 byte
		uint8_t result=0;
		for(i=0; i<8; i++) {//read every bit
			while(!(DHT11_PIN & (1<<DHT11_INPUTPIN))); //wait for an high input
			_delay_us(30);
			if(DHT11_PIN & (1<<DHT11_INPUTPIN)) //if input is high after 30 us, get result
			result |= (1<<(7-i));
			while(DHT11_PIN & (1<<DHT11_INPUTPIN)); //wait until input get low
		}
		bits[j] = result;
	}
	
	//reset port
	DHT11_DDR |= (1<<DHT11_INPUTPIN); //output
	DHT11_PORT |= (1<<DHT11_INPUTPIN); //low
	_delay_ms(100);
	
	//check checksum
	if (bits[0] + bits[1] + bits[2] + bits[3] == bits[4]) {
		if (select == 0) { //return temperature
			return(bits[2]);
			} else if(select == 1){ //return humidity
			return(bits[0]);
		}
	}
	
	return DHT11_ERROR;
}

void dht11_getdata(uint8_t num, uint8_t *data){
	uint8_t buf = getdata(num);
	if(buf == DHT11_ERROR){
		;
	}
	else{
		*data = buf;
	}
}