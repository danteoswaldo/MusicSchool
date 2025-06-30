using System.Net.Http.Json;

public class ProfesorApiService
{
    private readonly HttpClient _http;
    public ProfesorApiService(HttpClient http) => _http = http;

    public async Task<List<Profesor>> ObtenerTodos()
        => await _http.GetFromJsonAsync<List<Profesor>>("api/profesor") ?? new();

    public async Task Crear(Profesor profesor)
        => await _http.PostAsJsonAsync("api/profesor", profesor);

    public async Task Actualizar(Profesor profesor)
        => await _http.PutAsJsonAsync($"api/profesor/{profesor.Id}", profesor);

    public async Task Eliminar(int id)
        => await _http.DeleteAsync($"api/profesor/{id}");
}

public class Profesor
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public string Identificacion { get; set; } = "";
}