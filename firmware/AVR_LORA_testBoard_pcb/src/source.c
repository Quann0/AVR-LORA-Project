
#include "source.h"
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
void TMR_vInit(void)
{
    /* Start timer 1 with clock prescaler CLK/1024 */
    /* Resolution is 139 us */
    /* Maximum time is 9.1 s */
    TCCR1A =  (0<<COM1A1)|(0<<COM1A0)|(0<<COM1B1)|(0<<COM1B0)
             |(0<<COM1C1)|(0<<COM1C0)|(0<<WGM11) |(0<<WGM10);

    TCCR1B =  (0<<ICNC1) |(0<<ICES1) |(0<<WGM13) |(0<<WGM12)
             |(1<<CS12)  |(0<<CS11)  |(1<<CS10);

    TCNT1 = 0;
    OCR1A = 7200;
    TIMSK |= (1<<OCIE1A);

}
void Variables_vInit()
{
	u8Data = 0;
	temperature = 0;
	humidity = 0;
	temp = 0;
	pDataReceive = (char *)calloc(100, sizeof(char));
	leftString = (char *)calloc(100, sizeof(char));
	rightString = (char *)calloc(100, sizeof(char));
	NullforLastString = "\0";
	Sum = 0;
	CheckSend = 0;
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
void String_dataSend(uint8_t a[4])
{
	for(int i=0;i < 4;i++)
	{
		USART0_vSendByte(a[i]);
	}
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
