document.getElementById("xsdValidation").addEventListener("click", function() {
    const data = {
        bia_di: 42.9,
        bii_di: 26,
        bit_di: 31.5,
        che_de: 17.7,
        che_di: 28,
        elb_di: 13.1,
        wri_di: 10.4,
        kne_di: 18.8,
        ank_di: 14.1,
        sho_gi: 106.2,
        che_gi: 89.5,
        wai_gi: 71.5,
        nav_gi: 74.5,
        hip_gi: 93.5,
        thi_gi: 51.5,
        bic_gi: 32.5,
        for_gi: 26,
        kne_gi: 34.5,
        cal_gi: 36.5,
        ank_gi: 23.5,
        wri_gi: 16.5,
        age: 21,
        wgt: 65.6,
        hgt: 174,
        sex: 1
    };

    let xmlBody = `<?xml version="1.0" encoding="UTF-8"?>
        <BodyMeasurement>`;
    
    Object.entries(data).forEach(([key, value]) => {
        xmlBody += `<${key}>${value}</${key}>`;
    });
    
    xmlBody += `</BodyMeasurement>`;

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
        alert("An error occurred while processing your request. Please try again later.");
    });
});
