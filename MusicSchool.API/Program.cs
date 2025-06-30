using Microsoft.EntityFrameworkCore;
using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Application.Interfaces.Services;
using MusicSchool.Application.Services;
using MusicSchool.Infrastructure.Context;
using MusicSchool.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MusicSchoolDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DB_Test")));

// Add services to the container.
builder.Services.AddScoped<IEscuelaRepository, EscuelaRepository>();
builder.Services.AddScoped<IEscuelaService, EscuelaService>();
builder.Services.AddScoped<IProfesorRepository, ProfesorRepository>();
builder.Services.AddScoped<IAlumnoProfesorRepository, AlumnoProfesorRepository>();
builder.Services.AddScoped<IAlumnoProfesorService, AlumnoProfesorService>();
builder.Services.AddScoped<IProfesorService, ProfesorService>();
builder.Services.AddScoped<IAlumnoRepository, AlumnoRepository>();
builder.Services.AddScoped<IAlumnoService, AlumnoService>();
builder.Services.AddScoped<IAlumnoEscuelaRepository, AlumnoEscuelaRepository>();
builder.Services.AddScoped<IAlumnoEscuelaService, AlumnoEscuelaService>();
builder.Services.AddScoped<IAsignacionProfesorEscuelaRepository, AsignacionProfesorEscuelaRepository>();
builder.Services.AddScoped<IAsignacionProfesorEscuelaService, AsignacionProfesorEscuelaService>();
builder.Services.AddScoped<IConsultasRepository, ConsultasRepository>();
builder.Services.AddScoped<IConsultasService, ConsultasService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
