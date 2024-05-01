from flask import Flask, request, jsonify
from lxml import etree

app = Flask(__name__)

RNG_FILE = "schema.rng"


@app.route('/validate-xml', methods=['GET'])
def validate_xml():
    try:
        xml_data = request.args.get('xml_data')
        
        if xml_data is None:
            return jsonify({"error": "XML data is missing in the query parameter."}), 400
        
        rng_schema = etree.parse(RNG_FILE)
        schema = etree.RelaxNG(rng_schema)
        
        xml_doc = etree.fromstring(xml_data)
        
        is_valid = schema.validate(xml_doc)
        
        if is_valid:
            return jsonify({"message": "XML is valid against the schema."}), 200
        else:
            return jsonify({"error": "XML validation failed."}), 400
    
    except etree.XMLSyntaxError as e:
        return jsonify({"error": f"Invalid XML syntax: {str(e)}"}), 400
    except Exception as e:
        return jsonify({"error": f"An error occurred: {str(e)}"}), 500

if __name__ == '__main__':
    app.run(debug=True)
