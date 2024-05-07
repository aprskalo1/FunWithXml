from flask import Flask, request, jsonify
from flask_cors import CORS
import xmlrpc.client

proxy = xmlrpc.client.ServerProxy("http://localhost:8000/")

app = Flask(__name__)
CORS(app)

@app.route("/weather")
def get_weather():
    city_name = request.args.get("city_name")
    if city_name:
        city_data = proxy.get_city_data(city_name)
        if city_data:
            return jsonify(city_data)
        else:
            return jsonify({"error": "City data not found"}), 404
    else:
        return jsonify({"error": "City name parameter is missing"}), 400

if __name__ == "__main__":
    app.run(debug=True)
