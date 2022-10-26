from machine import Pin, Timer
import utime
green = Pin(14, Pin.OUT)
red = Pin(10, Pin.OUT)
yellow = Pin(11, Pin.OUT)
tim = Timer()


def tick(timer):
    global green
    global red
    global yellow
    timeCheck = True
    green.toggle()
    start = utime.time()
    while timeCheck:
        if utime.time()-start >= 5:
            green.off()
            print("green Off")
            timeCheck = False

tim.init(freq=50, mode=Timer.PERIODIC, callback=tick)