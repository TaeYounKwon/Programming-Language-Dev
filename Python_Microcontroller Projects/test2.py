from machine import Pin
from machine import PWM
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
    def print_settings(self):
        print("Servo PMW Frequency: " + str(Servo.SERVO_FREQUENCY))
        print("Servo PWM Period (milliseconds): " + str(Servo.SERVO_PERIOD_IN_MILLISECONDS))
        print("Duty (milliseconds): " + str(self.duty_cycle_period))
        print("Duty/Period percentage: " + str(self.duty_cycle_percentage))
        print("Duty value (1:65535): " + str(self.duty_cycle))
        print("\n")
        utime.sleep(Servo.SLEEP_PERIOD_IN_SECONDS)