#-*-coding:UTF-8-*-
#!/usr/bin/env python
import RPi.GPIO as GPIO
import time

class rpiGpio
	LED = 4 
	status = True

	def __init__()
		GPIO.setmode(GPIO.BCM)
		GPIO.setup(LED, GPIO.OUT)

	def gpioStop()
		GPIO.cleanup()

	def setLed()
		GPIO.output(LED, status)
		status = not status

	def readStatus()
		return status
