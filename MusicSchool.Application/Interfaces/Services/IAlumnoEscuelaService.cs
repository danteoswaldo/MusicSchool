namespace MusicSchool.Application.Interfaces.Services;

public interface IAlumnoEscuelaService
{
    Task InscribirAlumnoAEscuela(int alumnoId, int escuelaId);
}