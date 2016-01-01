#-*-coding:UTF8-*-
#!/usr/bin/env python

import socket   #for sockets
import sys  #for exit

host = '192.168.2.108'
port = 80

def __init__()
	HOST = ''   # Symbolic name meaning all available interfaces
	PORT = 9999 # Arbitrary non-privileged port
	 
	s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
	print 'Socket created'

	s.listen(10)
	print 'Socket now listening'
	 
	try:
	    s.bind((HOST, PORT))
	except socket.error , msg:
	    print 'Bind failed. Error Code : ' + str(msg[0]) + ' Message ' + msg[1]
	    sys.exit()
	     
	print 'Socket bind complete'

	#wait to accept a connection - blocking call
	conn, addr = s.accept()
	 
	#display client information
	print 'Connected with ' + addr[0] + ':' + str(addr[1])

def sendMessage(message):
	
	s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
	print 'Socket created'
	 
	try:
	    s.bind((HOST, PORT))
	except socket.error , msg:
	    print 'Bind failed. Error Code : ' + str(msg[0]) + ' Message ' + msg[1]
	    sys.exit()
	     
	print 'Socket bind complete'
	 
	s.listen(10)
	print 'Socket now listening'
	 
	#now keep talking with the client
	while 1:
	    #wait to accept a connection - blocking call
	    conn, addr = s.accept()
	    print 'Connected with ' + addr[0] + ':' + str(addr[1])
	     
	    data = conn.recv(1024)
	    reply = 'OK...' + data
	    if not data: 
	        break
	     
	    conn.sendall(reply)
	 
	conn.close()
	s.close()
	
	print 'Message send successfully'