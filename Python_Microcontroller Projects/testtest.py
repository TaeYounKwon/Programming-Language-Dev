import machine
import utime
import _thread
internal_led = machine. Pin (25, machine. Pin.OUT)

def first_thread():
   while True:
        global internal_led
        internal_led.toggle()
        utime.sleep(0.2)
        print ("Hello, I am the first_thread writing every sec")
        utime. sleep(1)
        
def second_thread():
    while True:
        print ("Hello, I am the sec_thread writing every sec")
        utime. sleep(1)
def third_thread():
    while True:
        print ("Hello, I am the third_thread writing every other sec")
        utime. sleep (2)
        
_thread.start_new_thread (second_thread, ())
_thread.start_new_thread (third_thread, ())
first_thread()
