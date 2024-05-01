from xmlrpc.server import SimpleXMLRPCServer
import xml.etree.ElementTree as ET
import requests

def get_city_data(city_name):
    url = "https://vrijeme.hr/hrvatska_n.xml"
    response = requests.get(url)
    root = ET.fromstring(response.content)
    for grad in root.findall('Grad'):
        if grad.find('GradIme').text.lower() == city_name.lower():
            return {
                'city_name': grad.find('GradIme').text,
                'latitude': grad.find('Lat').text,
                'longitude': grad.find('Lon').text,
                'temperature': grad.find('Podatci/Temp').text,
                'humidity': grad.find('Podatci/Vlaga').text,
                'pressure': grad.find('Podatci/Tlak').text,
                'wind_direction': grad.find('Podatci/VjetarSmjer').text,
                'wind_speed': grad.find('Podatci/VjetarBrzina').text,
                'weather_description': grad.find('Podatci/Vrijeme').text
            }
    return None

server = SimpleXMLRPCServer(("localhost", 8000))
print("Listening on port 8000...")

server.register_function(get_city_data, "get_city_data")

server.serve_forever()
