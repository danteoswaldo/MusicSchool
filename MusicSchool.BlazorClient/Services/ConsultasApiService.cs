using System.Net.Http.Json;
using MusicSchool.Application.DTOs;

public class ConsultasApiService
{
    private readonly HttpClient _http;
    public ConsultasApiService(HttpClient http) => _http = http;

    public async Task<List<AlumnoPorProfesorDto>> ObtenerAlumnosPorProfesor(int profesorId)
        => await _http.GetFromJsonAsync<List<AlumnoPorProfesorDto>>($"api/consultas/alumnos-por-profesor/{profesorId}");

    public async Task<List<EscuelaAlumnoDto>> ObtenerEscuelasYAlumnosPorProfesor(int profesorId)
        => await _http.GetFromJsonAsync<List<EscuelaAlumnoDto>>($"api/consultas/escuelas-alumnos-por-profesor/{profesorId}");
}