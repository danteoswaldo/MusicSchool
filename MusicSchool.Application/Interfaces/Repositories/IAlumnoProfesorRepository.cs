namespace MusicSchool.Application.Interfaces.Repositories;

public interface IAlumnoProfesorRepository
{
    Task AsignarAlumnosAProfesor(int profesorId, List<int> alumnoIds);
}
