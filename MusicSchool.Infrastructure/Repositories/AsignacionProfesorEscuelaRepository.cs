using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MusicSchool.Infrastructure.Context;
using MusicSchool.Application.Interfaces.Repositories;

namespace MusicSchool.Infrastructure.Repositories;

public class AsignacionProfesorEscuelaRepository : IAsignacionProfesorEscuelaRepository
{
    private readonly MusicSchoolDbContext _context;
    public AsignacionProfesorEscuelaRepository(MusicSchoolDbContext context) => _context = context;

    public async Task AsignarProfesorAEscuela(int profesorId, int escuelaId)
    {
        await _context.Database.ExecuteSqlRawAsync("EXEC spAsignarProfesorAEscuela @ProfesorId, @EscuelaId",
            new SqlParameter("@ProfesorId", profesorId),
            new SqlParameter("@EscuelaId", escuelaId));
    }
}