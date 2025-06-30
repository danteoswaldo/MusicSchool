using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Domain.Entities;
using MusicSchool.Infrastructure.Context;

namespace MusicSchool.Infrastructure.Repositories;

public class AlumnoRepository : IAlumnoRepository
{
    private readonly MusicSchoolDbContext _context;

    public AlumnoRepository(MusicSchoolDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Alumno>> ObtenerTodos()
    {
        return await _context.Alumnos
            .FromSqlRaw("EXEC spObtenerTodosAlumnos")
            .ToListAsync();
    }

    public async Task<Alumno?> ObtenerPorId(int id)
    {
        var result = await _context.Alumnos
            .FromSqlRaw("EXEC spObtenerAlumnoPorId @Id",
                new SqlParameter("@Id", id))
            .ToListAsync();

        return result.FirstOrDefault();
    }

    public async Task Crear(Alumno alumno)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "EXEC spCrearAlumno @Nombre, @Apellido, @FechaNacimiento, @Identificacion",
            new SqlParameter("@Nombre", alumno.Nombre),
            new SqlParameter("@Apellido", alumno.Apellido),
            new SqlParameter("@FechaNacimiento", alumno.FechaNacimiento),
            new SqlParameter("@Identificacion", alumno.Identificacion));
    }

    public async Task Actualizar(Alumno alumno)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "EXEC spActualizarAlumno @Id, @Nombre, @Apellido, @FechaNacimiento, @Identificacion",
            new SqlParameter("@Id", alumno.Id),
            new SqlParameter("@Nombre", alumno.Nombre),
            new SqlParameter("@Apellido", alumno.Apellido),
            new SqlParameter("@FechaNacimiento", alumno.FechaNacimiento),
            new SqlParameter("@Identificacion", alumno.Identificacion));
    }

    public async Task Eliminar(int id)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "EXEC spEliminarAlumno @Id",
            new SqlParameter("@Id", id));
    }
}
