################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../src/DHT.c \
../src/main.c \
../src/myLCD.c \
../src/source.c 

OBJS += \
./src/DHT.o \
./src/main.o \
./src/myLCD.o \
./src/source.o 

C_DEPS += \
./src/DHT.d \
./src/main.d \
./src/myLCD.d \
./src/source.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: AVR Compiler'
	avr-gcc -I"C:\Users\QUAN\source\repos\UART-CS\firmware\AVR_LORA_testBoard_pcb\inc" -Wall -Os -fpack-struct -fshort-enums -ffunction-sections -fdata-sections -std=gnu99 -funsigned-char -funsigned-bitfields -mmcu=atmega128 -DF_CPU=7372800UL -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -c -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


