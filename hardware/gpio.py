#-*-coding:UTF-8-*-
#!/usr/bin/env python
import RPi.GPIO as GPIO
import time

class rpiGpio
	LED1 = 4
	LED2 = 17
	LED3 = 27
	LED4 = 22
	status1 = True
	status2 = True
	status3 = True
	status4 = True

	def __init__()
		GPIO.setmode(GPIO.BCM)
		GPIO.setup(LED, GPIO.OUT)

	def gpioStop():
		GPIO.cleanup()

	def setLed1():
		GPIO.output(LED1, status1)
		status1 = not status1
		return status1

	def setLed2():
		GPIO.output(LED2, status2)
		status2 = not status2
		return status2

	def setLed3():
		GPIO.output(LED3, status3)
		status3 = not status3
		return status3

	def setLed4():
		GPIO.output(LED4, status4)
		status4 = not status4
		return status4

	def readStatus1():
		return status1

	def readStatus2():
		return status2

	def readStatus3():
		return status3

	def readStatus4():
		return status4
