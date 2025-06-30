namespace MusicSchool.Domain.Entities;

public class Escuela
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public string Codigo { get; set; } = string.Empty;
}