#-*-coding:UTF-8-*-
import RPi.GPIO as GPIO
import time

LED = 4 

GPIO.setmode(GPIO.BCM)
GPIO.setup(LED, GPIO.OUT)

print("结束程序，请按CTRL+C")
try:
	while 1:
		GPIO.output(LED, False)
		#延时1s
		time.sleep(1)
		GPIO.output(LED, True)
		time.sleep(1)
except KeyboardInterrupt: # 如果程序被CTRL+C结束
	GPIO.cleanup()
