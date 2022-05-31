#ifndef SOURCE_H_INCLUDED
#define SOURCE_H_INCLUDED

#define F_CPU 7372800UL
#include <avr/io.h>
#include <stdint.h>
#include <avr/interrupt.h>
#include <util/delay.h>
#include <string.h>
#include <stdlib.h>
#include <avr/iom128.h>
#include "myLCD.h"
#include "IO_Macros.h"
#include "DHT_Settings.h"
#include "DHT.h"

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

//Variables
uint8_t u8Data;
uint8_t temperature;
uint8_t humidity;
uint8_t data[4];
uint8_t *pDataReceive,*NullforLastString;
uint8_t *leftString, *rightString;
int Sum;
int CheckSend;
void USART0_vInit(void);
void Init_IO(void);
void TMR_vInit(void);
void String_dataSend(uint8_t a[4]);
void USART0_vSendByte(uint8_t u8Data);
uint8_t USART0_vReceiveByte();
#endif
