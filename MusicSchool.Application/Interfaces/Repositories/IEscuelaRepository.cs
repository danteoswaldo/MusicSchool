using MusicSchool.Domain.Entities;

namespace MusicSchool.Application.Interfaces.Repositories;

public interface IEscuelaRepository
{
    Task<IEnumerable<Escuela>> ObtenerTodas();
    Task<Escuela?> ObtenerPorId(int id);
    Task Crear(Escuela escuela);
    Task Actualizar(Escuela escuela);
    Task Eliminar(int id);
}
