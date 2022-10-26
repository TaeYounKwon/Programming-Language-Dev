import machine
from machine import I2C
from lcd_api import LcdApi
from i2c_lcd import I2cLcd

I2C_ADDR = 0x27
totalRows = 2
totalColumns = 16

i2c = I2C(0, sda=machine.Pin(0), scl=machine.Pin(1), freq=400000)
lcd = I2cLcd(i2c, I2C_ADDR, totalRows, totalColumns)

heart = bytearray([0x00,0x00,0x1B,0x1F,0x1F,0x0E,0x04,0x00])
face = bytearray([0x00,0x00,0x0A,0x00,0x11,0x0E,0x00,0x00])
degree = bytearray ([ 0x00, 0x0E, 0x0A, 0x0E, 0x00, 0x00, 0x00, 0x00])

lcd.custom_char(0, heart)
lcd.custom_char(1, face)
lcd.custom_char(2, degree)
lcd.putstr(chr(0)+" WELCOME "+chr(1) + chr(2))