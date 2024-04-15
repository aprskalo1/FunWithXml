using FunWithXml_API.Data;
using FunWithXml_API.Models;

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
            if (bodyMeasurement == null)
            {
                throw new ArgumentNullException(nameof(bodyMeasurement));
            }
            await _context.BodyMeasurements.AddAsync(bodyMeasurement);
            await _context.SaveChangesAsync();
            return bodyMeasurement;
        }
    }
}
