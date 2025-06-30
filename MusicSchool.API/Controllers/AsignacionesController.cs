using Microsoft.AspNetCore.Mvc;
using MusicSchool.Application.Interfaces.Services;

namespace MusicSchool.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AsignacionesController : ControllerBase
{
    private readonly IAsignacionProfesorEscuelaService _profesorEscuelaService;
    private readonly IAlumnoProfesorService _alumnoProfesorService;

    public AsignacionesController(
        IAsignacionProfesorEscuelaService profesorEscuelaService,
        IAlumnoProfesorService alumnoProfesorService)
    {
        _profesorEscuelaService = profesorEscuelaService;
        _alumnoProfesorService = alumnoProfesorService;
    }

    [HttpPost("profesor-a-escuela")]
    public async Task<IActionResult> AsignarProfesorAEscuela(int profesorId, int escuelaId)
    {
        await _profesorEscuelaService.AsignarProfesorAEscuela(profesorId, escuelaId);
        return Ok();
    }

    [HttpPost("alumno-a-profesor")]
    public async Task<IActionResult> AsignarAlumnoAProfesor(int profesorId, int alumnoId)
    {
        await _alumnoProfesorService.AsignarAlumnosAProfesor(profesorId, new List<int> { alumnoId });
        return Ok();
    }
}