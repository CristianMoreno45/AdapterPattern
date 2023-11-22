using SoapCore;
using WebApiSoap.Interfaces;
using WebApiSoap.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddScoped<ISoapService, MockSoapService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISoapService>("/service.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});
app.UseRouting();

app.Run();