using System.Net.Http.Json;

public class AlumnoApiService
{
    private readonly HttpClient _http;
    public AlumnoApiService(HttpClient http) => _http = http;

    public async Task<List<Alumno>> ObtenerTodos()
        => await _http.GetFromJsonAsync<List<Alumno>>("api/alumno") ?? new();

    public async Task Crear(Alumno alumno)
        => await _http.PostAsJsonAsync("api/alumno", alumno);

    public async Task Actualizar(Alumno alumno)
        => await _http.PutAsJsonAsync($"api/alumno/{alumno.Id}", alumno);

    public async Task Eliminar(int id)
        => await _http.DeleteAsync($"api/alumno/{id}");
}

public class Alumno
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public DateTime FechaNacimiento { get; set; }
    public string Identificacion { get; set; } = "";
}