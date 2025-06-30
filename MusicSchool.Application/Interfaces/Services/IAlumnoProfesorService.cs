namespace MusicSchool.Application.Interfaces.Services;

public interface IAlumnoProfesorService
{
    Task AsignarAlumnosAProfesor(int profesorId, List<int> alumnoIds);
}