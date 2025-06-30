namespace MusicSchool.Domain.Entities;

public class ProfesorEscuela
{
    public int ProfesorId { get; set; }
    public Profesor Profesor { get; set; } = null!;

    public int EscuelaId { get; set; }
    public Escuela Escuela { get; set; } = null!;
}
