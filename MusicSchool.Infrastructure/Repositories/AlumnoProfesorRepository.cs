using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Infrastructure.Context;

namespace MusicSchool.Infrastructure.Repositories;

public class AlumnoProfesorRepository : IAlumnoProfesorRepository
{
    private readonly MusicSchoolDbContext _context;

    public AlumnoProfesorRepository(MusicSchoolDbContext context)
    {
        _context = context;
    }

    public async Task AsignarAlumnosAProfesor(int profesorId, List<int> alumnoIds)
    {
        foreach (var alumnoId in alumnoIds)
        {
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC spAsignarAlumnoAProfesor @AlumnoId, @ProfesorId",
                new SqlParameter("@AlumnoId", alumnoId),
                new SqlParameter("@ProfesorId", profesorId)
            );
        }
    }
}
