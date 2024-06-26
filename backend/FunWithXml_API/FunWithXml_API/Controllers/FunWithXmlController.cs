﻿using FunWithXml_API.Models;
using FunWithXml_API.Services;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public async Task<IActionResult> PostBodyMeasurement(BodyMeasurement bodyMeasurement)
        {
            string message = await _bodyMeasurementsService.PostBodyMeasurementAsync(bodyMeasurement);
            return Ok(message);
        }

        [HttpGet("GetBodyMeasurement")]
        [Authorize]
        public IActionResult GetBodyMeasurement(int age)
        {
            var value = _soapService.SearchXmlFile(age);
            return Ok(value);
        }
    }
}
