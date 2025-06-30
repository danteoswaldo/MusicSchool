public class InscripcionApiService
{
    private readonly HttpClient _http;
    public InscripcionApiService(HttpClient http) => _http = http;

    public async Task InscribirAlumno(int alumnoId, int escuelaId)
    {
        await _http.PostAsync($"api/inscripciones?alumnoId={alumnoId}&escuelaId={escuelaId}", null);
    }
}