using FunWithXml_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FunWithXml_API.Data
{
    public class FunWithXmlDbContext : DbContext
    {
        public FunWithXmlDbContext(DbContextOptions<FunWithXmlDbContext> options) : base(options)
        {
        }

        public DbSet<BodyMeasurement> BodyMeasurements { get; set; }
        public DbSet<LoginModel> LoginModel { get; set; }
        public DbSet<BlackListedTokens> BlackListedTokens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=FunWithXML;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }
    }
}
