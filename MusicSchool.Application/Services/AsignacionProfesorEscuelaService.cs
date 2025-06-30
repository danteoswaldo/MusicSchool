using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Application.Interfaces.Services;

namespace MusicSchool.Application.Services;

public class AsignacionProfesorEscuelaService : IAsignacionProfesorEscuelaService
{
    private readonly IAsignacionProfesorEscuelaRepository _repo;

    public AsignacionProfesorEscuelaService(IAsignacionProfesorEscuelaRepository repo)
    {
        _repo = repo;
    }

    public Task AsignarProfesorAEscuela(int profesorId, int escuelaId)
        => _repo.AsignarProfesorAEscuela(profesorId, escuelaId);
}
