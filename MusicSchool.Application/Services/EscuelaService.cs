using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Application.Interfaces.Services;
using MusicSchool.Domain.Entities;

namespace MusicSchool.Application.Services;

public class EscuelaService : IEscuelaService
{
    private readonly IEscuelaRepository _repo;

    public EscuelaService(IEscuelaRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<Escuela>> ObtenerTodas()
    {
        var escuelas = await _repo.ObtenerTodas();
        return escuelas.ToList(); // Convertir a List si el repo devuelve IEnumerable
    }

    public Task<Escuela?> ObtenerPorId(int id)
        => _repo.ObtenerPorId(id);

    public Task Crear(Escuela escuela)
        => _repo.Crear(escuela);

    public Task Actualizar(Escuela escuela)
        => _repo.Actualizar(escuela);

    public Task Eliminar(int id)
        => _repo.Eliminar(id);
}
