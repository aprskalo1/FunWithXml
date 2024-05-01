document.addEventListener("DOMContentLoaded", function () {
    document.getElementById("soapButton").addEventListener("click", function () {
        var csvData = "42.9,26,31.5,17.7,28,13.1,10.4,18.8,14.1,106.2,89.5,71.5,74.5,93.5,51.5,32.5,26,34.5,36.5,23.5,16.5,21,65.6,174,1";
        sendSoapRequest(csvData);
    });
});

function sendSoapRequest(csvData) {
    var soapRequest =
        `<?xml version="1.0" encoding="utf-8"?>
        <soap:Envelope xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
            <soap:Header>    
                <soap:Body>
                    <csvData>${csvData}</csvData>
                </soap:Body>
            <soap:Header>
        </soap:Envelope>`;

    var endpointUrl = 'https:/localhost:7238/SoapService.asmx/CsvToXmlFile';

    fetch(endpointUrl, {
        method: 'POST',
        headers: {
            'Content-Type': 'text/xml;charset=utf-8',
        },
        body: soapRequest
    })
        .then(response => response.text())
        .then(data => {
            console.log(data);
        })
        .catch(error => {
            console.error('Error:', error);
        });
}