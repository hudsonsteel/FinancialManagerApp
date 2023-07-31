using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    // Include XML comments in the Swagger JSON output (if you have XML comments enabled in your project)
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);

    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "FinancialManagerWebApi",
        Version = "v1"
    });
});

var app = builder.Build();


// Enable Swagger middleware
app.UseSwagger();

// Configure the Swagger UI
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "FinancialManagerWebApi (v1)");
    // Add additional Swagger endpoints if needed (e.g., for HTTPS)
    //c.SwaggerEndpoint("/swagger/v2/swagger.json", "Your API Name (v2)");
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
