namespace MusicSchool.Application.Interfaces.Services;

public interface IAsignacionProfesorEscuelaService
{
    Task AsignarProfesorAEscuela(int profesorId, int escuelaId);
}