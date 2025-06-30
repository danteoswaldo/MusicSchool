using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Infrastructure.Context;

namespace MusicSchool.Infrastructure.Repositories;

public class AlumnoEscuelaRepository : IAlumnoEscuelaRepository
{
    private readonly MusicSchoolDbContext _context;

    public AlumnoEscuelaRepository(MusicSchoolDbContext context)
    {
        _context = context;
    }

    public async Task InscribirAlumnoAEscuela(int alumnoId, int escuelaId)
    {
        await _context.Database.ExecuteSqlRawAsync(
            "EXEC spInscribirAlumnoAEscuela @AlumnoId, @EscuelaId",
            new SqlParameter("@AlumnoId", alumnoId),
            new SqlParameter("@EscuelaId", escuelaId)
        );
    }
}
