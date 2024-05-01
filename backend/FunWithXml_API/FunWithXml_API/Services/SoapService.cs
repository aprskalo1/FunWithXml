using System.Runtime.Serialization;
using System.ServiceModel;
using System.Xml.Serialization;
using System.Xml;
using FunWithXml_API.Models;
using CsvHelper;
using System.Globalization;

namespace FunWithXml_API.Services
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        void CsvToXmlFile(string csvData);
    }

    public class SoapService : ISoapService
    {
        private readonly string _xmlFilePath;

        public SoapService()
        {
            _xmlFilePath = Path.Combine(AppContext.BaseDirectory, "XmlFiles", "BodyMeasurement.xml");
        }

        public void CsvToXmlFile(string csvData)
        {
            using (var reader = new StringReader(csvData))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<BodyMeasurement>();

                var xmlSerializer = new XmlSerializer(typeof(List<BodyMeasurement>));
                using (var fileStream = new FileStream(_xmlFilePath, FileMode.Create))
                using (var xmlWriter = XmlWriter.Create(fileStream))
                {
                    xmlSerializer.Serialize(xmlWriter, records);
                }
            }
        }
    }
}
