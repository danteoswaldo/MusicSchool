using Microsoft.AspNetCore.Mvc;
using MusicSchool.Application.Interfaces.Services;

namespace MusicSchool.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsultasController : ControllerBase
{
    private readonly IConsultasService _service;
    public ConsultasController(IConsultasService service) => _service = service;

    [HttpGet("alumnos-por-profesor/{profesorId}")]
    public async Task<IActionResult> AlumnosPorProfesor(int profesorId)
        => Ok(await _service.ObtenerAlumnosPorProfesor(profesorId));

    [HttpGet("escuelas-alumnos-por-profesor/{profesorId}")]
    public async Task<IActionResult> EscuelasYAlumnosPorProfesor(int profesorId)
        => Ok(await _service.ObtenerEscuelasYAlumnosPorProfesor(profesorId));
}