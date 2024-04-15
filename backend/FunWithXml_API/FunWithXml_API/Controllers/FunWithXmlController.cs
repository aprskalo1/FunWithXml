using FunWithXml_API.Models;
using FunWithXml_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

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

        [HttpPost]
        [Consumes("application/xml")]
        public async Task<IActionResult> PostBodyMeasurement(BodyMeasurement bodyMeasurement)
        {
            try
            {
                var value = await _bodyMeasurementsService.PostBodyMeasurementAsync(bodyMeasurement);
                return Ok(value);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
