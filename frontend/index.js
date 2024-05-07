function generateXmlFromCsv(csvData) {
    const dataArray = csvData.split(',').map(entry => entry.trim());
    const keys = ['bia_di', 'bii_di', 'bit_di', 'che_de', 'che_di', 'elb_di', 'wri_di', 'kne_di', 'ank_di', 'sho_gi', 'che_gi', 'wai_gi', 'nav_gi', 'hip_gi', 'thi_gi', 'bic_gi', 'for_gi', 'kne_gi', 'cal_gi', 'ank_gi', 'wri_gi', 'age', 'wgt', 'hgt', 'sex'];

    if (dataArray.length !== keys.length) {
        throw new Error("Invalid CSV data. Make sure you have provided all the required values.");
    }

    const data = {};
    dataArray.forEach((value, index) => {
        data[keys[index]] = value;
    });

    let xmlBody = `<?xml version="1.0" encoding="UTF-8"?>
        <BodyMeasurement>`;

    Object.entries(data).forEach(([key, value]) => {
        xmlBody += `<${key}>${value}</${key}>`;
    });

    xmlBody += `</BodyMeasurement>`;

    return xmlBody;
}

document.getElementById("xsdValidation").addEventListener("click", function () {
    const csvData = document.getElementById("input").value.trim();

    try {
        const xmlBody = generateXmlFromCsv(csvData);

        fetch("https://localhost:7238/api/FunWithXml/PostBodyMeasurement", {
            method: "POST",
            headers: {
                "Content-Type": "application/xml"
            },
            body: xmlBody
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error("Network response was not ok");
                }
                return response.text();
            })
            .then(data => {
                console.log("Response:", data);
            })
            .catch(error => {
                console.error("Error:", error);
                alert("Error while validating against XSD. Please check the console for more details.");
            });
    } catch (error) {
        console.error("Error:", error);
        alert(error.message);
    }
});

document.getElementById("rngValidation").addEventListener("click", function () {
    const csvData = document.getElementById("input").value.trim();

    try {
        const xmlBody = generateXmlFromCsv(csvData);
        const xmlBodyWithoutVersion = xmlBody.replace(/<\?xml.*\?>/, "").trim();

        const url = "http://127.0.0.1:5000/validate-xml?xml_data=" + xmlBodyWithoutVersion;

        fetch(url, {
            method: "POST"
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error("Network response was not ok");
                }
                return response.text();
            })
            .then(data => {
                console.log("Response:", data);
            })
            .catch(error => {
                console.error("Error:", error);
                alert("Error while validating against RNG. Please check the console for more details.");
            });
    } catch (error) {
        console.error("Error:", error);
        alert(error.message);
    }
});

document.getElementById("soap").addEventListener("click", function () {
    const csvData = document.getElementById("input").value.trim();

    try {
        const soapEnvelope = `
            <Envelope xmlns="http://schemas.xmlsoap.org/soap/envelope/">
                <Body>
                    <CsvToXmlFile xmlns="http://tempuri.org/">
                        <csvData>${csvData}</csvData>
                    </CsvToXmlFile>
                </Body>
            </Envelope>
        `;

        fetch("https://localhost:7238/SoapService.asmx", {
            method: "POST",
            headers: {
                "Content-Type": "text/xml; charset=utf-8"
            },
            body: soapEnvelope
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error("Network response was not ok");
                }
                return response.text();
            })
            .then(data => {
                console.log("SOAP Response:", data);
            })
            .catch(error => {
                console.error("Error:", error);
                alert("Error while fetching data from SOAP service. Please check the console for more details.");
            });
    } catch (error) {
        console.error("Error:", error);
        alert(error.message);
    }
});

document.getElementById("cityTemp").addEventListener("click", function () {
    var cityName = document.getElementById("input").value.trim();
    if (!cityName) {
        alert("Please enter a city name.");
        return;
    }

    fetch("http://localhost:5000/weather?city_name=" + encodeURIComponent(cityName))
        .then(response => {
            if (!response.ok) {
                throw new Error("City data not found");
            }
            return response.json();
        })
        .then(data => {
            var temperature = data.temperature;
            alert(`Temperature in ${cityName}: ${temperature}°C`);
        })
        .catch(error => {
            console.error("Error:", error);
            alert(error.message);
        });
});

document.getElementById("age").addEventListener("click", function () {
    var input = document.getElementById("input").value.trim();
    if (!input) {
        alert("Please enter an age.");
        return;
    }

    var url = `https://localhost:7238/api/FunWithXml/GetBodyMeasurement?age=${encodeURIComponent(input)}`;

    fetch(url)
        .then(response => {
            if (!response.ok) {
                throw new Error("Person data not found");
            }
            return response.json();
        })
        .then(data => {
            var output = "Person Data:\n";
            output += `Age: ${data.age}\n`;
            output += `Weight: ${data.wgt} kg\n`;
            output += `Height: ${data.hgt} cm\n`;
            output += `Bia_di: ${data.bia_di}\n`;
            output += `Bii_di: ${data.bii_di}\n`;

            alert(output);
        })
        .catch(error => {
            console.error("Error:", error);
            alert(error.message);
        });
});
