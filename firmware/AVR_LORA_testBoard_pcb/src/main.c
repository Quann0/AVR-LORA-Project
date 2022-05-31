/*
 * Uart.c
 *
 * Created: 4/27/2022 8:01:59 PM
 * Author : QUAN
 */
#include <stdlib.h>
#include <string.h>
#include "source.h"
#include "DHT.h"

int main(void)
{

	Init_IO();
	init_LCD();
	TMR_vInit();
	Variables_vInit();
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
	DHT_Read(&temperature, &humidity);
	//Check status
	switch (DHT_GetStatus())
	{
		case (DHT_Ok):
			//Print temperature
			//print(temperature[0]);
			PORT_LED_O ^= (1<<BIT_LED_O);
			Sum = temperature*100 + humidity;
			itoa(Sum,data,10);
			clr_LCD();
			move_LCD(1,1);
			printf_LCD("Temp : %d",temperature);
			move_LCD(2,1);
			printf_LCD("Humi : %d",humidity);
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
ISR(USART0_RX_vect) { //hï¿½m ph?c v? ng?t nh?n c?a UART0 thay cho hï¿½m ISR(SIG_UART0_RECV)
	u8Data = USART0_vReceiveByte();
	if(u8Data)
	{
		*(pDataReceive + CheckSend++) = u8Data;
		if(*(pDataReceive + (CheckSend - 1)) == '~')
		{
			*(pDataReceive + (CheckSend - 1)) = *NullforLastString;
			if(strstr(pDataReceive,"buzOn"))
			{
				PORT_BUZ &= ~(1<<BIT_BUZ);
			}
			else if(strstr(pDataReceive,"buzOff"))
			{
				PORT_BUZ |= (1<<BIT_BUZ);
			}
			else if(strstr(pDataReceive,"ledOn"))
			{
				PORT_LED_O |= (1<<BIT_LED_O);
			}
			else if(strstr(pDataReceive,"ledOff"))
			{
				PORT_LED_O &= ~(1<<BIT_LED_O);
			}
			else
			{
				if(strlen(pDataReceive)>10)
				{
					//nay la cat chuoi ðó nhaaaa
					strncpy(leftString, pDataReceive + 0, 10);
					*(leftString + 10) = '\0';
					strncpy(rightString, pDataReceive + 10, (strlen(pDataReceive) - 10));
					*(rightString + (strlen(pDataReceive) - 10)) = '\0';

					clr_LCD();
					move_LCD(1, 1);
					printf_LCD("Data: %s", leftString);
					move_LCD(2,1);
					printf_LCD("%s", rightString);
				}
				else
				{
					clr_LCD();
					move_LCD(1, 1);
					printf_LCD("Data: %s", pDataReceive);
				}

			}
			CheckSend = 0;
			free(pDataReceive);
			pDataReceive = (uint8_t *)calloc(100, sizeof(uint8_t));
		}

	}
}

