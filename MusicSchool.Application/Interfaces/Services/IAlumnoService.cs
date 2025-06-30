using MusicSchool.Domain.Entities;

namespace MusicSchool.Application.Interfaces.Services;

public interface IAlumnoService
{
    Task<List<Alumno>> ObtenerTodos();
    Task<Alumno?> ObtenerPorId(int id);
    Task Crear(Alumno alumno);
    Task Actualizar(Alumno alumno);
    Task Eliminar(int id);
}