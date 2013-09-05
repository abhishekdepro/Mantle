import urllib2
import re

city=raw_input('enter city')
str1="&mode=xml&units=metric"
str=city+str1
url = "http://api.openweathermap.org/data/2.5/weather?q=%s" % str
source=urllib2.urlopen(url)

htmltext=source.read()
print("<------------------------WEATHER REPORT: "+city.upper()+"--------------------------->")

# search for pattern using regular expressions (.+?)
temperature='<temperature value="(.+?)" min="(.+?)" max="(.+?)" unit="(.+?)"/>'
humidity='<humidity value="(.+?)" unit="%"/>'
condition='<weather number="(.+?)" value="(.+?)" icon="(.+?)"/>'
wind='<speed value="(.+?)" name="(.+?)"/>'
pattern=re.compile(temperature)
pattern1=re.compile(condition)
pattern2=re.compile(humidity)
pattern3=re.compile(wind)

# match pattern with htmltext
weather_temp=re.findall(pattern,htmltext)
weather_condition=re.findall(pattern1,htmltext)
weather_humidity=re.findall(pattern2,htmltext)
weather_wind=re.findall(pattern3,htmltext)
print "Temperature is: ",weather_temp[0][1]," degree celcius"
print "Min. Temperature is: ",weather_temp[0][2]," degree celcius"
print "Wind: ",weather_wind[0][1]
print "Humidity: ",weather_humidity[0]," %"
print "Weather Condition is : ",weather_condition[0][1]
