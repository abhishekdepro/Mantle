#-------------------------------------------------------------------------------
# Name:        Select operation on backend
# Purpose:
#
# Author:      D1617 64
#
# Created:     11-08-2013
# Copyright:   (c) D1617 64 2013
# Licence:     <your licence>
#-------------------------------------------------------------------------------

import sqlite3
conn=sqlite3.connect("D://Programming/weather_forecast.db")
c=conn.cursor()
c.execute('select city,temp,weathercond FROM data')
table = c.fetchall()
for i in range(0,len(table)):
#	print table[i]
	for j in range(0,len(table[i])):
		print table[i][j]
	print "\t"
conn.close()
