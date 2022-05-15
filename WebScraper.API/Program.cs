using WebScraper.Application;
using WebScraper.Application.Services;
using WebScraper.Data.Data;
using Microsoft.EntityFrameworkCore;
using MediatR;

var allowedOrigins = "_AllowedOrigins";
var builder = WebApplication.CreateBuilder(args);

// adding controllers
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuring cors, allowing any method and headers from localhost:3000
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowedOrigins,
        builder =>
        {
            builder.WithOrigins("http://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});

// Adding database service
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Registering the mediator
builder.Services.AddMediatR(typeof(SearchEngineService).Assembly);

// Registering services
builder.Services.AddScoped<ISearchPositionsService, SearchPositionsService>();
builder.Services.AddScoped<ISearchHistoryService, SearchHistoryService>();
builder.Services.AddScoped<ISearchEngineService, SearchEngineService>();

// Adding the automapper package
builder.Services.AddAutoMapper(typeof(SearchEngineService).Assembly);

var app = builder.Build();

// Configure development environment for using swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app using cors
app.UseCors(allowedOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
