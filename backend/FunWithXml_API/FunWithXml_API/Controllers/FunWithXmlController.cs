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
        private readonly ISoapService _soapService;

        public FunWithXmlController(IBodyMeasurementsService bodyMeasurementsService, ISoapService soapService)
        {
            _bodyMeasurementsService = bodyMeasurementsService;
            _soapService = soapService;
        }

        [HttpPost("PostBodyMeasurement")]
        [Consumes("application/xml")]
        public async Task<IActionResult> PostBodyMeasurement(BodyMeasurement bodyMeasurement)
        {
            var value = await _bodyMeasurementsService.PostBodyMeasurementAsync(bodyMeasurement);
            return Ok(value);

        }

        [HttpGet("GetBodyMeasurement")]
        public IActionResult GetBodyMeasurement(int age)
        {
            var value = _soapService.SearchXmlFile(age);
            return Ok(value);
        }
    }
}
