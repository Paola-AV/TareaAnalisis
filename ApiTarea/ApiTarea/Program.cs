using ApiTarea_Application.Interface;
using ApiTarea_Application.Service;
using ApiTarea_infrastructure.Data;
using ApiTarea_infrastructure.Interface;
using ApiTarea_infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ConnectionService>();
builder.Services.AddSingleton<IPersonaService, PersonaService>();
builder.Services.AddSingleton<IPersonaRepository, PersonaRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
