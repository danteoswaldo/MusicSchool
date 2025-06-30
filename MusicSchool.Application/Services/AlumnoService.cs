using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Application.Interfaces.Services;
using MusicSchool.Domain.Entities;

namespace MusicSchool.Application.Services;

public class AlumnoService : IAlumnoService
{
    private readonly IAlumnoRepository _repo;

    public AlumnoService(IAlumnoRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<Alumno>> ObtenerTodos()
    {
        var alumnos = await _repo.ObtenerTodos();
        return alumnos.ToList();
    }

    public Task<Alumno?> ObtenerPorId(int id)
        => _repo.ObtenerPorId(id);

    public Task Crear(Alumno alumno)
        => _repo.Crear(alumno);

    public Task Actualizar(Alumno alumno)
        => _repo.Actualizar(alumno);

    public Task Eliminar(int id)
        => _repo.Eliminar(id);
}
