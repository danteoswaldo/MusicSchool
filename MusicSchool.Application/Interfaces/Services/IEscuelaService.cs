using MusicSchool.Domain.Entities;

namespace MusicSchool.Application.Interfaces.Services;

public interface IEscuelaService
{
    Task<List<Escuela>> ObtenerTodas();
    Task<Escuela?> ObtenerPorId(int id);
    Task Crear(Escuela escuela);
    Task Actualizar(Escuela escuela);
    Task Eliminar(int id);
}