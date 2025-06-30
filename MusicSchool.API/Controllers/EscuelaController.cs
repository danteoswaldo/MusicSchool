using Microsoft.AspNetCore.Mvc;
using MusicSchool.Application.Interfaces.Services;
using MusicSchool.Domain.Entities;

namespace MusicSchool.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EscuelaController : ControllerBase
{
    private readonly IEscuelaService _service;

    public EscuelaController(IEscuelaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _service.ObtenerTodas());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var escuela = await _service.ObtenerPorId(id);
        return escuela == null ? NotFound() : Ok(escuela);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Escuela escuela)
    {
        await _service.Crear(escuela);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Escuela escuela)
    {
        if (id != escuela.Id) return BadRequest();
        await _service.Actualizar(escuela);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.Eliminar(id);
        return Ok();
    }
}