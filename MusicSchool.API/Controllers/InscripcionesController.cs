using Microsoft.AspNetCore.Mvc;
using MusicSchool.Application.Interfaces.Services;

namespace MusicSchool.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InscripcionesController : ControllerBase
{
    private readonly IAlumnoEscuelaService _service;
    public InscripcionesController(IAlumnoEscuelaService service) => _service = service;

    [HttpPost]
    public async Task<IActionResult> InscribirAlumno(int alumnoId, int escuelaId)
    {
        await _service.InscribirAlumnoAEscuela(alumnoId, escuelaId);
        return Ok();
    }
}