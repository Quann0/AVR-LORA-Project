/*
 * Uart.c
 *
 * Created: 4/27/2022 8:01:59 PM
 * Author : QUAN
 */
#define F_CPU 7372800UL
#include <avr/io.h>
#include <stdint.h>
#include <avr/interrupt.h>
#include <util/delay.h>
#include <string.h>
#include <stdlib.h>
#include <avr/iom128.h>
#include "myLCD.h"
#ifndef DHT11_H_
#define DHT11_H_

#define DHT11_ERROR 255
#define DHT11_DDR DDRF
#define DHT11_PORT PORTF
#define DHT11_PIN PINF
#define DHT11_INPUTPIN PF1
#define PORT_LED_O      PORTB
#define DDR_LED_O       DDRB
#define BIT_LED_O       6
// Output Port pin Buzzer
#define PORT_BUZ       PORTB
#define DDR_BUZ        DDRB
#define BIT_BUZ        7
#define PORT_BT			PB5

// Define baud rate
#define USART0_BAUD         115200ul
#define USART0_UBBR_VALUE   ((F_CPU/(USART0_BAUD<<4))-1)

#endif /* DHT11_H_ */

void dht11_getdata(uint8_t num, uint8_t *data);
uint8_t getdata(uint8_t select);
void USART0_vInit(void)
{
    // Set baud rate
    UBRR0H = (uint8_t)(USART0_UBBR_VALUE>>8);
    UBRR0L = (uint8_t)USART0_UBBR_VALUE;

    // Set frame format to 8 data bits, no parity, 1 stop bit
    UCSR0C = (0<<USBS)|(1<<UCSZ1)|(1<<UCSZ0);

    // Enable receiver and transmitter
    UCSR0B = (1<<RXEN)|(1<<TXEN)|(1<<RXCIE);
}
void Init_IO(void) {
	// Set LED_BUZ as output pin
	DDR_LED_O |= (1 << BIT_LED_O); //|= la OR (1<<BIT_LED_O) dich trai so bit = voi gia tri BIT_LED_O
	DDR_BUZ |= (1 << BIT_BUZ); //nhu tren
	PORT_LED_O &= ~(1 << BIT_LED_O);
	PORT_BUZ |= (1 << BIT_BUZ);
	DDR_BUZ &= ~(1 << PORT_BT);
	PORT_BUZ |= (1 << PORT_BT);
}
//char data[4];
char data[2];
const char *fixbug = "0";
void uart_char_tx(unsigned char chr)
{
	while (bit_is_clear(UCSR0A,UDRE0)) { };
	UDR0=chr;

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
		uart_char_tx(a[i]);
	}
}
void USART0_vSendByte(uint8_t u8Data)
{
    // Wait if a byte is being transmitted
    while((UCSR0A&(1<<UDRE0)) == 0) //
    {
        ;
    }

    // Transmit data
    UDR0 = u8Data;
}

uint8_t USART0_vReceiveByte()
{
    // Wait until a byte has been received
    while((UCSR0A&(1<<RXC0)) == 0)
    {
        ;
    }

    // Return received data
    return UDR0;
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
volatile unsigned char u8Data;
int main(void){
	Init_IO();
	init_LCD();
//	Init_interrupt();
	USART0_vInit();
	USART0_vSendByte('A');
	USART0_vSendByte('V');
	USART0_vSendByte('R');
	USART0_vSendByte('\r');
	USART0_vSendByte('\n');
	clr_LCD();
	move_LCD(1,1);
	printf_LCD("Data");
	_delay_ms(500);
	//Baudrate 115200ul, t?n s? f=7372800MHz
//	UCSR0A=0x00;
//	UCSR0C =(1<<UCSZ01)|(1<<UCSZ00);
//	UCSR0B =(1<<RXEN0)|(1<<TXEN0)|(1<<RXCIE0); //cho phép truy?n nh?n d? li?u và cho phép ng?t nh?n
	//ADMUX |= (1<<REFS0); //Ch?n ?i?n áp tham chi?u AVCC
	//ADCSRA |=(1<<ADEN) | (1<<ADPS2) | (1<<ADPS0);//Cho phép ADC và ch?n h? s? chia xung nh?p cho ADC là 32.
//	sei(); //cho phép ng?t toàn c?c (bit I
    /* Replace with your application code */
//	uint16_t nhietdo=0
	uint8_t datatemp = 0;
	uint8_t dataHumi = 0;
	uint16_t DataSum = 0;
	clr_LCD();
	move_LCD(1,1);
	printf_LCD("Temp: %d",datatemp);
	move_LCD(2,1);
	printf_LCD("Humi: %d",dataHumi);
	_delay_ms(500);
	sei();
    while (1)
    {
    	clr_LCD();
		dht11_getdata(0, &datatemp);
		dht11_getdata(1, &dataHumi);
		//DataSum=datatemp*100+dataHumi;
		move_LCD(1,1);
		printf_LCD("Temp: %d",datatemp);
		move_LCD(2,1);
		printf_LCD("Humi: %d",dataHumi);
//    	u8Data = USART0_vReceiveByte();
//    				if(u8Data)
//    				{
//    					clr_LCD();
//    					if(u8Data =='2')
//    					{
//    						PORT_LED_O |= (1<<BIT_LED_O);
//    					}
//    					else if(u8Data =='1')
//    					{
//    						PORT_LED_O &= ~(1<<BIT_LED_O);
//    					}
//    					//*a = u8Data1;
//    					else if(u8Data == 'b')
//    					{
//    						PORT_BUZ ^= (1<<BIT_BUZ);
//    					}
//    					clr_LCD();
//    					move_LCD(1, 1);
//    					printf_LCD("Data: %c", u8Data);
//    					_delay_ms(1000);
//    				}
//    				USART0_vSendByte(u8Data);
    }
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
ISR(USART0_RX_vect) { //hàm ph?c v? ng?t nh?n c?a UART0 thay cho hàm ISR(SIG_UART0_RECV)
	u8Data = USART0_vReceiveByte();
			if(u8Data)
			{
				clr_LCD();
				if(u8Data =='2')
				{
					PORT_LED_O |= (1<<BIT_LED_O);
				}
				else if(u8Data =='1')
				{
					PORT_LED_O &= ~(1<<BIT_LED_O);
				}
				//*a = u8Data1;
				else if(u8Data == 'b')
				{
					PORT_BUZ ^= (1<<BIT_BUZ);
				}
				clr_LCD();
				move_LCD(1, 1);
				printf_LCD("Data: %c", u8Data);
			}
			USART0_vSendByte(u8Data);
}
