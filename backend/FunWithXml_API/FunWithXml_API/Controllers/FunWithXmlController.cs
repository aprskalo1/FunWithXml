using FunWithXml_API.Models;
using FunWithXml_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace FunWithXml_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FunWithXmlController : ControllerBase
    {
        private readonly IBodyMeasurementsService _bodyMeasurementsService;

        public FunWithXmlController(IBodyMeasurementsService bodyMeasurementsService)
        {
            _bodyMeasurementsService = bodyMeasurementsService;
        }

        [HttpPost("PostBodyMeasurement")]
        [Consumes("application/xml")]
        public async Task<IActionResult> PostBodyMeasurement(BodyMeasurement bodyMeasurement)
        {
            var value = await _bodyMeasurementsService.PostBodyMeasurementAsync(bodyMeasurement);
            return Ok(value);
        }
    }
}
