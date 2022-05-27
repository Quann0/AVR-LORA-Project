/*
 * Uart.c
 *
 * Created: 4/27/2022 8:01:59 PM
 * Author : QUAN
 */
#include <stdlib.h>
#include "source.h"
#include "DHT.h"
int main(void){
	Init_IO();
	init_LCD();
	TMR_vInit();
	USART0_vInit();
	sei();
	USART0_vSendByte('A');
	USART0_vSendByte('V');
	USART0_vSendByte('R');
	USART0_vSendByte('\r');
	USART0_vSendByte('\n');
	clr_LCD();
	move_LCD(1,1);
	printf_LCD("Test LCD");
	_delay_ms(500);
    while (1)
    {
    }
}
ISR(TIMER1_COMPA_vect)
{
	//Read from sensor
	DHT_Read(temperature, humidity);
	//Check status
	switch (DHT_GetStatus())
	{
		case (DHT_Ok):
			//Print temperature
			//print(temperature[0]);
			PORT_LED_O ^= (1<<BIT_LED_O);
			Sum = temperature[0]*100 + humidity[0];
			itoa(Sum,data,10);
			clr_LCD();
			move_LCD(1,1);
			printf_LCD("Temp : %d",temperature[0]);
			move_LCD(2,1);
			printf_LCD("Humi : %d",humidity[0]);
			String_dataSend(data);
			//Print humidity
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
}
ISR(USART0_RX_vect) { //h�m ph?c v? ng?t nh?n c?a UART0 thay cho h�m ISR(SIG_UART0_RECV)
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
}

