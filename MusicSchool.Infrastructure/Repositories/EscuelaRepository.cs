using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Domain.Entities;
using MusicSchool.Infrastructure.Context;

namespace MusicSchool.Infrastructure.Repositories;

public class EscuelaRepository : IEscuelaRepository
{
    private readonly MusicSchoolDbContext _context;

    public EscuelaRepository(MusicSchoolDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Escuela>> ObtenerTodas()
    {
        return await _context.Escuelas
            .FromSqlRaw("EXEC spObtenerTodasEscuelas")
            .ToListAsync();
    }

    public async Task<Escuela?> ObtenerPorId(int id)
    {
        var result = await _context.Escuelas
            .FromSqlRaw("EXEC spObtenerEscuelaPorId @Id",
                new SqlParameter("@Id", id))
            .ToListAsync();

        return result.FirstOrDefault();
    }

    public async Task Crear(Escuela escuela)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "EXEC spCrearEscuela @Codigo, @Nombre, @Descripcion",
            new SqlParameter("@Codigo", escuela.Codigo),
            new SqlParameter("@Nombre", escuela.Nombre),
            new SqlParameter("@Descripcion", escuela.Descripcion));
    }

    public async Task Actualizar(Escuela escuela)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "EXEC spActualizarEscuela @Id, @Codigo, @Nombre, @Descripcion",
            new SqlParameter("@Id", escuela.Id),
            new SqlParameter("@Codigo", escuela.Codigo),
            new SqlParameter("@Nombre", escuela.Nombre),
            new SqlParameter("@Descripcion", escuela.Descripcion));
    }

    public async Task Eliminar(int id)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "EXEC spEliminarEscuela @Id",
            new SqlParameter("@Id", id));
    }
}
