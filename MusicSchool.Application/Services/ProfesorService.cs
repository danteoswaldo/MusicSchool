using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Application.Interfaces.Services;
using MusicSchool.Domain.Entities;

namespace MusicSchool.Application.Services;

public class ProfesorService : IProfesorService
{
    private readonly IProfesorRepository _repo;

    public ProfesorService(IProfesorRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<Profesor>> ObtenerTodos()
    {
        var profesores = await _repo.ObtenerTodos();
        return profesores.ToList();
    }

    public Task<Profesor?> ObtenerPorId(int id)
        => _repo.ObtenerPorId(id);

    public Task Crear(Profesor profesor)
        => _repo.Crear(profesor);

    public Task Actualizar(Profesor profesor)
        => _repo.Actualizar(profesor);

    public Task Eliminar(int id)
        => _repo.Eliminar(id);
}
