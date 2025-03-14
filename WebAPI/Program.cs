using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.OpenApi.Models;
using QRCodeGeneratorPresentation.Common.Helpers;
using QRCodeGeneratorPresentation.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new RouteTokenTransformerConvention(
        new SlugifyRouteTransformer()
    ));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // Read xml to display content
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFilename);
    options.IncludeXmlComments(xmlPath);

    // Add annotations to Swagger
    options.EnableAnnotations();

    // Add more information for API
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "QR Code Generator API",
        Version = "v1",
        Description = "API for generating QR code",
        Contact = new OpenApiContact
        {
            Name = "QuanDH",
            Email = "daniel.richard.09911142@gmail.com",
            Url = new Uri("https://github.com/rickymta")
        }
    });
});

// Register DeleteOldFilesService as a hosted service
builder.Services.AddHostedService<DeleteOldFilesService>();

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

app.Run();
