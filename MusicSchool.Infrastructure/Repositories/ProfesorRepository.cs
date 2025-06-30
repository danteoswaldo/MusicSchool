using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Domain.Entities;
using MusicSchool.Infrastructure.Context;

namespace MusicSchool.Infrastructure.Repositories;

public class ProfesorRepository : IProfesorRepository
{
    private readonly MusicSchoolDbContext _context;

    public ProfesorRepository(MusicSchoolDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Profesor>> ObtenerTodos()
    {
        return await _context.Profesores
            .FromSqlRaw("EXEC spObtenerTodosProfesores")
            .ToListAsync();
    }

    public async Task<Profesor?> ObtenerPorId(int id)
    {
        var result = await _context.Profesores
            .FromSqlRaw("EXEC spObtenerProfesorPorId @Id",
                new SqlParameter("@Id", id))
            .ToListAsync();

        return result.FirstOrDefault();
    }

    public async Task Crear(Profesor profesor)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "EXEC spCrearProfesor @Nombre, @Apellido, @Identificacion",
            new SqlParameter("@Nombre", profesor.Nombre),
            new SqlParameter("@Apellido", profesor.Apellido),
            new SqlParameter("@Identificacion", profesor.Identificacion));
    }

    public async Task Actualizar(Profesor profesor)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "EXEC spActualizarProfesor @Id, @Nombre, @Apellido, @Identificacion",
            new SqlParameter("@Id", profesor.Id),
            new SqlParameter("@Nombre", profesor.Nombre),
            new SqlParameter("@Apellido", profesor.Apellido),
            new SqlParameter("@Identificacion", profesor.Identificacion));
    }

    public async Task Eliminar(int id)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "EXEC spEliminarProfesor @Id",
            new SqlParameter("@Id", id));
    }
}
