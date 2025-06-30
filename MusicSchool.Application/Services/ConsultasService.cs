using MusicSchool.Application.DTOs;
using MusicSchool.Application.Interfaces.Repositories;
using MusicSchool.Application.Interfaces.Services;

namespace MusicSchool.Application.Services;

public class ConsultasService : IConsultasService
{
    private readonly IConsultasRepository _repo;

    public ConsultasService(IConsultasRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<AlumnoPorProfesorDto>> ObtenerAlumnosPorProfesor(int profesorId)
    {
        var result = await _repo.ObtenerAlumnosPorProfesor(profesorId);
        return result.ToList();
    }

    public async Task<List<EscuelaAlumnoDto>> ObtenerEscuelasYAlumnosPorProfesor(int profesorId)
    {
        var result = await _repo.ObtenerEscuelasYAlumnosPorProfesor(profesorId);
        return result.ToList();
    }
}
