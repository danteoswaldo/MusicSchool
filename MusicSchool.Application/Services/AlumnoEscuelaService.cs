using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Application.Interfaces.Services;

namespace MusicSchool.Application.Services;

public class AlumnoEscuelaService : IAlumnoEscuelaService
{
    private readonly IAlumnoEscuelaRepository _repo;

    public AlumnoEscuelaService(IAlumnoEscuelaRepository repo)
    {
        _repo = repo;
    }

    public Task InscribirAlumnoAEscuela(int alumnoId, int escuelaId)
        => _repo.InscribirAlumnoAEscuela(alumnoId, escuelaId);
}