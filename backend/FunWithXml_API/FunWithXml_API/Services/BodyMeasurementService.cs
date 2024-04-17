using FunWithXml_API.Data;
using FunWithXml_API.Models;
using System.Xml.Linq;
using System.Xml.Schema;

namespace FunWithXml_API.Services
{
    public interface IBodyMeasurementsService
    {
        Task<BodyMeasurement> PostBodyMeasurementAsync(BodyMeasurement bodyMeasurement);
    }

    public class BodyMeasurementService : IBodyMeasurementsService
    {
        private readonly FunWithXmlDbContext _context;

        public BodyMeasurementService(FunWithXmlDbContext context)
        {
            _context = context;
        }

        public async Task<BodyMeasurement> PostBodyMeasurementAsync(BodyMeasurement bodyMeasurement)
        {
            try
            {
                if (!ValidateWithXSD(bodyMeasurement.ToXml()))
                {
                    throw new Exception("XSD validation failed, please check your XML body.");
                }

                await _context.BodyMeasurements.AddAsync(bodyMeasurement);
                await _context.SaveChangesAsync();
                return bodyMeasurement;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool ValidateWithXSD(string xmlData)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", "ValidationSchemas/BodyMeasurement.xsd");

            XDocument doc = XDocument.Parse(xmlData);

            bool isValid = true;
            doc.Validate(schemas, (o, e) =>
            {
                isValid = false;
            });

            return isValid;
        }
    }
}
