using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Application.Interfaces.Services;

namespace MusicSchool.Application.Services;

public class AlumnoProfesorService : IAlumnoProfesorService
{
    private readonly IAlumnoProfesorRepository _repo;

    public AlumnoProfesorService(IAlumnoProfesorRepository repo)
    {
        _repo = repo;
    }

    public Task AsignarAlumnosAProfesor(int profesorId, List<int> alumnoIds)
        => _repo.AsignarAlumnosAProfesor(profesorId, alumnoIds);
}
