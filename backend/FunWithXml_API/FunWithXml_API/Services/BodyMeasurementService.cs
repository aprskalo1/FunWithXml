﻿using FunWithXml_API.Data;
using FunWithXml_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
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
            try
            {
                await _context.BodyMeasurements.AddAsync(bodyMeasurement);
                await _context.SaveChangesAsync();
                return bodyMeasurement;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}