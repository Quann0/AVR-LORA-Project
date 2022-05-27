################################################################################
# Automatically-generated file. Do not edit!
################################################################################

-include ../makefile.init

RM := rm -rf

# All of the sources participating in the build are defined here
-include sources.mk
-include src/subdir.mk
-include subdir.mk
-include objects.mk

ifneq ($(MAKECMDGOALS),clean)
ifneq ($(strip $(ASM_DEPS)),)
-include $(ASM_DEPS)
endif
ifneq ($(strip $(S_DEPS)),)
-include $(S_DEPS)
endif
ifneq ($(strip $(S_UPPER_DEPS)),)
-include $(S_UPPER_DEPS)
endif
ifneq ($(strip $(C_DEPS)),)
-include $(C_DEPS)
endif
endif

-include ../makefile.defs

# Add inputs and outputs from these tool invocations to the build variables 
LSS += \
project_Emb.lss \

FLASH_IMAGE += \
project_Emb.hex \

EEPROM_IMAGE += \
project_Emb.eep \

SIZEDUMMY += \
sizedummy \


# All Target
all: project_Emb.elf secondary-outputs

# Tool invocations
project_Emb.elf: $(OBJS) $(USER_OBJS)
	@echo 'Building target: $@'
	@echo 'Invoking: AVR C Linker'
	avr-gcc -Wl,-Map,project_Emb.map -Wl,-u,vfprintf -lprintf_flt -mmcu=atmega128 -o "project_Emb.elf" $(OBJS) $(USER_OBJS) $(LIBS)
	@echo 'Finished building target: $@'
	@echo ' '

project_Emb.lss: project_Emb.elf
	@echo 'Invoking: AVR Create Extended Listing'
	-avr-objdump -h -S project_Emb.elf  >"project_Emb.lss"
	@echo 'Finished building: $@'
	@echo ' '

project_Emb.hex: project_Emb.elf
	@echo 'Create Flash image (ihex format)'
	-avr-objcopy -R .eeprom -R .fuse -R .lock -R .signature -O ihex project_Emb.elf  "project_Emb.hex"
	@echo 'Finished building: $@'
	@echo ' '

project_Emb.eep: project_Emb.elf
	@echo 'Create eeprom image (ihex format)'
	-avr-objcopy -j .eeprom --no-change-warnings --change-section-lma .eeprom=0 -O ihex project_Emb.elf  "project_Emb.eep"
	@echo 'Finished building: $@'
	@echo ' '

sizedummy: project_Emb.elf
	@echo 'Invoking: Print Size'
	-avr-size --format=avr --mcu=atmega128 project_Emb.elf
	@echo 'Finished building: $@'
	@echo ' '

# Other Targets
clean:
	-$(RM) $(FLASH_IMAGE)$(ELFS)$(OBJS)$(ASM_DEPS)$(EEPROM_IMAGE)$(S_DEPS)$(SIZEDUMMY)$(S_UPPER_DEPS)$(LSS)$(C_DEPS) project_Emb.elf
	-@echo ' '

secondary-outputs: $(LSS) $(FLASH_IMAGE) $(EEPROM_IMAGE) $(SIZEDUMMY)

.PHONY: all clean dependents
.SECONDARY:

-include ../makefile.targets
