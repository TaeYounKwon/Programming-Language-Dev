from machine import Pin, Timer, PWM
import utime

class Servo():
    MAX_DUTY_CYCLE = 2**16 - 1 #largest unsigned int (65535)
    SLEEP_PERIOD_IN_SECONDS = 2
    MILLISECONDS_PER_SECOND = 1000
    SERVO_PERIOD_IN_MILLISECONDS = 20
    SERVO_FREQUENCY = int(MILLISECONDS_PER_SECOND / SERVO_PERIOD_IN_MILLISECONDS)
    SERVO_RIGHT_TURN_DUTY = 0.5  #Set duty to 0.5 milliseconds
    SERVO_GO_STRAIGHT_DUTY = 1.5 #Set duty to 1.5 milliseconds
    SERVO_LEFT_TURN_DUTY = 2.5   #Set duty to 2.5 milliseconds
    SERVO_NORTH_EAST_DUTY = 1.0  #Set duty to 1.0 milliseconds
    SERVO_NORTH_WEST_DUTY = 2.0  #Set duty to 1.0 milliseconds
    
    def __init__(self, pin, frequency=50):
        self.pwm_pin = PWM(pin)
        self.pwm_pin.freq(frequency)
        self.duty_cycle = 0
        
    def set_position_by_duty_cycle(self, duty_cycle_period):
        self.duty_cycle_period = duty_cycle_period
        
        self.duty_cycle_percentage = (duty_cycle_period/Servo.SERVO_PERIOD_IN_MILLISECONDS) * 100 
  
        self.duty_cycle = Servo.MAX_DUTY_CYCLE * (self.duty_cycle_percentage/100)
    
        self.pwm_pin.duty_u16(int(self.duty_cycle))
    
    #Set the motor by angle (0~180 degree)
    def set_position_by_angle(self,angle):
        if angle > 180:
            angle = 180
        elif angle<0:
            angle = 0
            
        duty_cycle_period = 0.5 + float(angle/90)    
        
        self.duty_cycle_period = duty_cycle_period
        
        self.duty_cycle_percentage = (duty_cycle_period/Servo.SERVO_PERIOD_IN_MILLISECONDS) * 100 
  
        self.duty_cycle = Servo.MAX_DUTY_CYCLE * (self.duty_cycle_percentage/100)
    
        self.pwm_pin.duty_u16(int(self.duty_cycle))
    
    #Get time and degree by user and use set_position_by_angle to change the motor position
    def set_time(self, degree,time):
        end = time
            
        start = utime.time()  
        servo.set_position_by_angle(degree)
        loopOut = True
        isZero = False
        
        #If 0 sec, pass and terminate the program
        if end == 0:
            isZero = True
            pass
        #If time not zero, then move the servo motor and stay for user time
        else:
            while(loopOut):
                current = utime.time()
                if current - start >= end:
                    loopOut=False
                    utime.sleep(Servo.SLEEP_PERIOD_IN_SECONDS)
                    break
        
        #Return bool isZero value to stop the program
        return isZero
        
    def print_settings(self):
        print("Servo PMW Frequency: " + str(Servo.SERVO_FREQUENCY))
        print("Servo PWM Period (milliseconds): " + str(Servo.SERVO_PERIOD_IN_MILLISECONDS))
        print("Duty (milliseconds): " + str(self.duty_cycle_period))
        print("Duty/Period percentage: " + str(self.duty_cycle_percentage))
        print("Duty value (1:65535): " + str(self.duty_cycle))
        print("\n")
        utime.sleep(Servo.SLEEP_PERIOD_IN_SECONDS)

#END_CLASS     
#Need a 20 millisecond period
#1000 Cycles/Second = 1 Millisecond/Cycle (1/1000)
#50 Cycles/Second = 20 Milliseconds/Cycle (1/50)
servo = Servo(Pin(1), Servo.SERVO_FREQUENCY)
loopOut=True

#To repeat the process only 1 time
count = 0

while loopOut:
        
    print("Servo is going 90 degree for 2 seconds")
    outNow = servo.set_time(90,2)
    if outNow ==True:
        loopOut = False
        break
    
    print("Servo is going 180 degree for 2 seconds")
    outNow = servo.set_time(180,2)
    if outNow ==True:
        loopOut = False
        break
    
        
    print("Servo is going 0 degree for 2 seconds")
    outNow = servo.set_time(0,2)
    if outNow ==True:
        loopOut = False
        break
    
    print("Servo is going 135 degree for 2 seconds")
    outNow = servo.set_time(135,2)
    if outNow ==True:
        loopOut = False
        break
    
    print("Servo is going 45 degree for 2 seconds")
    outNow = servo.set_time(45,2)
    if outNow ==True:
        loopOut = False
        break
    
    print("Servo is going 90 degree for 5 seconds")
    outNow =  servo.set_time(90,2)  
    if outNow ==True:
        loopOut = False
        break
    
    #after the first loop, run set_time function with 0 seconds 
    if count>0:
        print("Servo is going 5 degree for 0 seconds")
        outNow =  servo.set_time(5,0)  
    
    #end of the while loop
    if outNow ==True:
        loopOut = False
        break
        
    
    count += 1
    
    #show repeating process
    if outNow != True:
        print("")
        print("***Start from beginning***")
        print("")