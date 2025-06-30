namespace MusicSchool.Domain.Entities;

public class Profesor
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Identificacion { get; set; } = string.Empty;
}