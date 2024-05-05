package hr.algebra.jaxbvalidation;

import java.io.File;
import javax.xml.transform.stream.StreamSource;
import javax.xml.validation.Schema;
import javax.xml.validation.SchemaFactory;
import javax.xml.validation.Validator;
import org.xml.sax.SAXException;

public class JAXBValidation {

    public static void main(String[] args) {
        String xmlFile = "C:\\Users\\Ante Prskalo\\OneDrive\\Radna površina\\FunWithXml\\backend\\JAXBValidation\\Xml\\BodyMeasurement.xml";
        String xsdFile = "C:\\Users\\Ante Prskalo\\OneDrive\\Radna površina\\FunWithXml\\backend\\JAXBValidation\\Xml\\BodyMeasurement.xsd";

        validate(xmlFile, xsdFile);
    }

    private static void validate(String xmlFile, String xsdFile) {
        try {
            SchemaFactory sf = SchemaFactory.newInstance(javax.xml.XMLConstants.W3C_XML_SCHEMA_NS_URI);
            Schema employeeSchema = sf.newSchema(new File(xsdFile));

            Validator validator = employeeSchema.newValidator();

            validator.validate(new StreamSource(new File(xmlFile)));

            System.out.println("XML is valid.");
        } catch (SAXException e) {
            System.out.println("XML is not valid: " + e.getMessage());
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
