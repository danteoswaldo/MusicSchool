using System.Net.Http.Json;

public class AsignacionApiService
{
    private readonly HttpClient _http;
    public AsignacionApiService(HttpClient http) => _http = http;

    public async Task AsignarProfesorAEscuela(int profesorId, int escuelaId)
        => await _http.PostAsync($"api/asignaciones/profesor-a-escuela?profesorId={profesorId}&escuelaId={escuelaId}", null);

    public async Task AsignarAlumnoAProfesor(int alumnoId, int profesorId)
        => await _http.PostAsync($"api/asignaciones/alumno-a-profesor?alumnoId={alumnoId}&profesorId={profesorId}", null);
}