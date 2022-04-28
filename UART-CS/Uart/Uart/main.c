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
void uart_char_tx(unsigned char chr) 
{
	while (bit_is_clear(UCSR0A,UDRE0)) { };
	UDR0=chr;
}
volatile unsigned char u_data;
int main(void){
	//Baudrate 9600, t?n s? f=8MHz
	//C?u h?nh UART0
	DDRB = 0xff;
	UBRR0H=0;
	UBRR0L=51;
	UCSR0A=0x00;
	UCSR0C =(1<<UCSZ01)|(1<<UCSZ00);
	UCSR0B =(1<<RXEN0)|(1<<TXEN0)|(1<<RXCIE0); //cho ph�p truy?n nh?n d? li?u v� cho ph�p ng?t nh?n
	sei(); //cho ph�p ng?t to�n c?c (bit I
    /* Replace with your application code */
    while (1) 
    {
    }
}

ISR(USART0_RX_vect) { //h�m ph?c v? ng?t nh?n c?a UART0 thay cho h�m ISR(SIG_UART0_RECV)
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