using Microsoft.AspNetCore.Mvc;
using MusicSchool.Application.Interfaces.Services;
using MusicSchool.Domain.Entities;

namespace MusicSchool.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfesorController : ControllerBase
{
    private readonly IProfesorService _service;
    public ProfesorController(IProfesorService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _service.ObtenerTodos());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _service.ObtenerPorId(id);
        return result == null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Profesor profesor)
    {
        await _service.Crear(profesor);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] Profesor profesor)
    {
        if (id != profesor.Id) return BadRequest();
        await _service.Actualizar(profesor);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.Eliminar(id);
        return Ok();
    }
}