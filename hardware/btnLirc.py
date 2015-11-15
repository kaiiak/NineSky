import RPi.GPIO as GPIO
from Buttons import Buttons

try:
	while 1:
		nb = btn.readButton()
		fi nb == 'left':
			
