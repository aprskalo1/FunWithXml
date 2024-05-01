using FunWithXml_API.Data;
using FunWithXml_API.Services;
using Microsoft.EntityFrameworkCore;
using SoapCore;
using System.ServiceModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddXmlSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<FunWithXmlDbContext>(options =>
{
    options.UseSqlServer("name=ConnectionStrings:DefaultConnection");
});

builder.Services.AddScoped<IBodyMeasurementsService, BodyMeasurementService>();
builder.Services.AddScoped<ISoapService, SoapService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseSoapEndpoint<ISoapService>("/SoapService.svc", new SoapEncoderOptions());

app.Run();
