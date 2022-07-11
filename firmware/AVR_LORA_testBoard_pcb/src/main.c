/*
 * Uart.c
 *
 * Created: 4/27/2022 8:01:59 PM
 * Author : QUAN
 */

#include "source.h"

int main(void)
{
	Init_IO();
	init_LCD();
	TMR_vInit();
	Variables_vInit();
	USART0_vInit();
	sei();
	clr_LCD();
	move_LCD(1,1);
	printf_LCD("Test LCD123");
    while (1)
    {
    }
}

ISR(TIMER1_COMPA_vect)
{
	//Read from sensor
	DHT_Read(&temperature, &humidity); //double
	//Check status
	switch (DHT_GetStatus())
	{
		case (DHT_Ok):
			//Print temperature
			//print(temperature[0]);
			PORT_LED_O ^= (1<<BIT_LED_O);
			//temp 32,40
			data[0] = (uint8_t)temperature; //32
			temp = (temperature - data[0])*10; //(32,4 - 32)*10 = 4
			data[1] = (uint8_t)temp;
			//humi
			data[2] = (uint8_t)humidity;
			temp = (humidity - data[2])*10;
			data[3] = (uint8_t)temp;

			if(temperature > 30 || humidity > 90)
			{
				PORT_BUZ &= ~(1<<BIT_BUZ);
			}
			else
			{
				PORT_BUZ |= (1<<BIT_BUZ);
			}
			clr_LCD();
			move_LCD(1,1);
			printf_LCD("Temp : %d.%d0",data[0],data[1]);
			move_LCD(2,1);
			printf_LCD("Humi : %d.%d0",data[2],data[3]);
			String_dataSend(data);
			//Print humidity
			break;
		case (DHT_Error_Checksum):
				clr_LCD();
				move_LCD(1,1);
				printf_LCD("DHT_Error_Checksum");
			break;
		case (DHT_Error_Timeout):
				clr_LCD();
				move_LCD(1,1);
				printf_LCD("DHT_Error_Timeout");
			break;
		case (DHT_Error_Humidity):
				clr_LCD();
				move_LCD(1,1);
				printf_LCD("DHT_Error_Humidity");
			break;
		case (DHT_Error_Temperature):
			clr_LCD();
			move_LCD(1,1);
			printf_LCD("DHT_Error_Temperature");
		//Do something else
			break;
	}
}

ISR(USART0_RX_vect) { //h�m ph?c v? ng?t nh?n c?a UART0 thay cho h�m ISR(SIG_UART0_RECV)
	u8Data = USART0_vReceiveByte();
	if(u8Data)
	{
		*(pDataReceive + CheckSend++) = (char)u8Data;
		if(*(pDataReceive + (CheckSend - 1)) == '\n')
		{
			*(pDataReceive + (CheckSend - 1)) = *NullforLastString;
			if(strstr(pDataReceive,"buzOn"))
			{
				PORT_OUT |= (1 << BIT_BUZ_OUT);
			}
			else if(strstr(pDataReceive,"buzOff"))
			{
				PORT_OUT &= ~(1 << BIT_BUZ_OUT);
			}
			else if(strstr(pDataReceive,"ledOn"))
			{
				PORT_OUT |= (1 << BIT_LED_OUT);
			}
			else if(strstr(pDataReceive,"ledOff"))
			{
				PORT_OUT &= ~(1<<BIT_LED_OUT);
			}
			else
			{
				if(strlen(pDataReceive)>((pSIZE_STRING_LCD/2) - 1))
				{
					//cut string left
					strncpy(leftString, pDataReceive + 0, (pSIZE_STRING_LCD/2) - 1);
					*(leftString + ((pSIZE_STRING_LCD/2) - 1)) = *NullforLastString;
					//cut string right
					strncpy(rightString, pDataReceive + ((pSIZE_STRING_LCD/2) - 1), (strlen(pDataReceive) - ((pSIZE_STRING_LCD/2) - 1)));
					*(rightString + (strlen(pDataReceive) - ((pSIZE_STRING_LCD/2) - 1))) = *NullforLastString;
					//print string on LCD
					clr_LCD();
					move_LCD(1, 1);
					printf_LCD("%s", leftString);
					move_LCD(2,1);
					printf_LCD("%s", rightString);
					free(leftString);
					free(rightString);
					leftString = (char *)calloc(pSIZE_STRING_LCD/2, sizeof(char));
					rightString = (char *)calloc(pSIZE_STRING_LCD/2, sizeof(char));
				}
				else
				{
					clr_LCD();
					move_LCD(1, 1);
					printf_LCD("%s", pDataReceive);
				}
			}
			//reset variables
			CheckSend = 0;
			free(pDataReceive);
			pDataReceive = (char *)calloc(pSIZE_STRING_LCD, sizeof(char));
		}

	}
}

