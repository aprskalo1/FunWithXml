using FunWithXml_API.Data;
using FunWithXml_API.Models;
using System.Xml.Schema;
using System.Xml.Serialization;

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
            throw new NotImplementedException();
        }
    }
}
