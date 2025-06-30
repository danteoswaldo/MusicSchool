using Microsoft.AspNetCore.Mvc;
using MusicSchool.Application.Interfaces.Services;
using MusicSchool.Domain.Entities;

namespace MusicSchool.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlumnoController : ControllerBase
{
    private readonly IAlumnoService _service;
    public AlumnoController(IAlumnoService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _service.ObtenerTodos());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _service.ObtenerPorId(id);
        return result == null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Alumno alumno)
    {
        await _service.Crear(alumno);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Alumno alumno)
    {
        if (id != alumno.Id) return BadRequest();
        await _service.Actualizar(alumno);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.Eliminar(id);
        return Ok();
    }
}