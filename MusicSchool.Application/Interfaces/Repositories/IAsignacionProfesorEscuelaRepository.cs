namespace MusicSchool.Application.Interfaces.Repositories;

public interface IAsignacionProfesorEscuelaRepository
{
    Task AsignarProfesorAEscuela(int profesorId, int escuelaId);
}
