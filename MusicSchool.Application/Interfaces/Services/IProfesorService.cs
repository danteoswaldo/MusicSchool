using MusicSchool.Domain.Entities;

namespace MusicSchool.Application.Interfaces.Services;

public interface IProfesorService
{
    Task<List<Profesor>> ObtenerTodos();
    Task<Profesor?> ObtenerPorId(int id);
    Task Crear(Profesor profesor);
    Task Actualizar(Profesor profesor);
    Task Eliminar(int id);
}