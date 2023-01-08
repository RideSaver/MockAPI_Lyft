using LyftAPI.Interface;
using LyftAPI.Repository;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Security.Cryptography.X509Certificates;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();


builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString;
});

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IPublicRepository, PublicRepository>();

builder.Services.Configure<ListenOptions>(options =>
{
    options.UseHttps(new X509Certificate2(Path.Combine("/certs/tls.crt"), Path.Combine("/certs/tls.key")));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler(new ExceptionHandlerOptions() { AllowStatusCode404Response = true, ExceptionHandlingPath = "/error" });
app.UseHttpLogging();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseHttpsRedirection();

app.MapControllers();
app.MapHealthChecks("/healthz");
app.UseRouting();

app.Logger.LogInformation("[MockAPI::Lyft] Finished middleware configuration.. starting the MockAPI.");

app.Run();
