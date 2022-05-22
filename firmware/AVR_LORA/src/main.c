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
#include "DHT.h"

//#define DHT11_ERROR 255
//#define DHT11_DDR DDRF
//#define DHT11_PORT PORTF
//#define DHT11_PIN PINF
//#define DHT11_INPUTPIN PF1
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
void uart_char_tx(unsigned char chr)
{
	while (bit_is_clear(UCSR0A,UDRE0)) { };
	UDR0=chr;

}
void gui_1_chuoi_dulieu( char a[2])
{
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

	clr_LCD();
	//Variables
	uint8_t temperature[1];
	uint8_t humidity[1];

	//Setup
	DHT_Setup();
	sei();
    while (1)
    {
    	//Read from sensor
    			DHT_Read(temperature, humidity);

    			//Check status
    			switch (DHT_GetStatus())
    			{
    				case (DHT_Ok):
    					//Print temperature
    					//print(temperature[0]);
					clr_LCD();
						move_LCD(1,1);
						printf_LCD("Temp : %d",temperature[0]);
						move_LCD(2,1);
						printf_LCD("Humi : %d",humidity[0]);
						_delay_ms(100);
						data[0] = temperature[0];
						data[1] = humidity[0];
						gui_1_chuoi_dulieu(data);
    					//Print humidity
    					//print(humidity[0]);
    					break;
    				case (DHT_Error_Checksum):
						//Do something
						break;
					case (DHT_Error_Timeout):
						//Do something else
						break;
					case (DHT_Error_Humidity):
						//Do something else
						break;
					case (DHT_Error_Temperature):
						//Do something else
						break;
    			}

    			//Sensor needs 1-2s to stabilize its readings
    			_delay_ms(1000);

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
