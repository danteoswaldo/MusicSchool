using MusicSchool.Application.DTOs;

namespace MusicSchool.Application.Interfaces.Services;

public interface IConsultasService
{
    Task<List<AlumnoPorProfesorDto>> ObtenerAlumnosPorProfesor(int profesorId);
    Task<List<EscuelaAlumnoDto>> ObtenerEscuelasYAlumnosPorProfesor(int profesorId);
}