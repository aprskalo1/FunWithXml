using FunWithXml_API.Data;
using FunWithXml_API.Models;
using System.Xml.Linq;
using System.Xml.Schema;

namespace FunWithXml_API.Services
{
    public interface IBodyMeasurementsService
    {
        Task<string> PostBodyMeasurementAsync(BodyMeasurement bodyMeasurement);
    }

    public class BodyMeasurementService : IBodyMeasurementsService
    {
        private readonly FunWithXmlDbContext _context;

        public BodyMeasurementService(FunWithXmlDbContext context)
        {
            _context = context;
        }

        public async Task<string> PostBodyMeasurementAsync(BodyMeasurement bodyMeasurement)
        {
            try
            {
                List<string> validationErrors = ValidateWithXSD(bodyMeasurement.ToXml());
                if (validationErrors.Count > 0)
                {
                    return string.Join(", ", validationErrors);
                }

                await _context.BodyMeasurements.AddAsync(bodyMeasurement);
                await _context.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return "Body Measurement added successfully!";
        }

        private List<string> ValidateWithXSD(string xmlData)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", "ValidationSchemas/BodyMeasurement.xsd");

            XDocument doc = XDocument.Parse(xmlData);

            List<string> validationErrors = new List<string>();
            doc.Validate(schemas, (o, e) =>
            {
                validationErrors.Add(e.Message);
            });

            return validationErrors;
        }
    }
}
