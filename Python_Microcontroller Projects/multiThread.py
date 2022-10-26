from machine import Pin
import time
import _thread
button = Pin(14, Pin.IN, Pin.PULL_DOWN)
led = Pin(15, Pin.OUT)

def button_thread_0():
    global button_pressed
    
    print("Checking state of global button_pressed...")
    
    button_pressed.acquire()
    led.on()
    print("Cross street light on...")
    time.sleep(5)
    led.off()
    print("Cross street light off...")
    button_pressed = False
    print("Set state of global button_pressed to false...")
    time.sleep_ms(2000)
    button_pressed.release()
    

def button_thread_1():
    global button_pressed
    
    button_pressed.acquire()
    button_pressed = True
    print("Set state of global button_pressed to true...")
    time.sleep_ms(500)
    button_pressed.release()   

button_pressed = _thread.allocate_lock()
second_thread = _thread.start_new_thread(button_thread_1, ())
led.off()
button_thread_0()

