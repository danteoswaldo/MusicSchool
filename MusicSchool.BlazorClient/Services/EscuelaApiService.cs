using System.Net.Http.Json;

public class EscuelaApiService
{
    private readonly HttpClient _http;
    public EscuelaApiService(HttpClient http) => _http = http;

    public async Task<List<Escuela>> ObtenerTodas()
        => await _http.GetFromJsonAsync<List<Escuela>>("api/escuela") ?? new();

    public async Task Crear(Escuela escuela)
        => await _http.PostAsJsonAsync("api/escuela", escuela);

    public async Task Actualizar(Escuela escuela)
        => await _http.PutAsJsonAsync($"api/escuela/{escuela.Id}", escuela);

    public async Task Eliminar(int id)
        => await _http.DeleteAsync($"api/escuela/{id}");
}

public class Escuela
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string? Descripcion { get; set; }
    public string Codigo { get; set; } = "";
}