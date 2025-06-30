using MusicSchool.Domain.Entities;

namespace MusicSchool.Application.Interfaces.Repositories;

public interface IProfesorRepository
{
    Task<IEnumerable<Profesor>> ObtenerTodos();
    Task<Profesor?> ObtenerPorId(int id);
    Task Crear(Profesor profesor);
    Task Actualizar(Profesor profesor);
    Task Eliminar(int id);
}