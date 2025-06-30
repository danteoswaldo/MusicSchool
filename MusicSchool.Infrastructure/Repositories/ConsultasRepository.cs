using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Application.DTOs;
using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Infrastructure.Context;

namespace MusicSchool.Infrastructure.Repositories;
public class ConsultasRepository : IConsultasRepository
{
    private readonly MusicSchoolDbContext _context;

    public ConsultasRepository(MusicSchoolDbContext context)
    {
        _context = context;
    }

    public async Task<List<AlumnoPorProfesorDto>> ObtenerAlumnosPorProfesor(int profesorId)
    {
        var param = new SqlParameter("@ProfesorId", profesorId);

        return await _context.Set<AlumnoPorProfesorDto>()
            .FromSqlRaw("EXEC spAlumnosPorProfesor @ProfesorId", param)
            .ToListAsync();
    }

    public async Task<List<EscuelaAlumnoDto>> ObtenerEscuelasYAlumnosPorProfesor(int profesorId)
    {
        var param = new SqlParameter("@ProfesorId", profesorId);

        return await _context.Set<EscuelaAlumnoDto>()
            .FromSqlRaw("EXEC spEscuelasYAlumnosPorProfesor @ProfesorId", param)
            .ToListAsync();
    }
}
