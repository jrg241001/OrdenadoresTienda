using API_EjercicioIntroduccionDatosOrdenadores.Models;
using Microsoft.AspNetCore.Mvc;
using static API_EjercicioIntroduccionDatosOrdenadores.Services.IRepositorio;

[Route("api/[controller]")]
[ApiController]
public class ComponentesController : ControllerBase
{
    private readonly IRepositorio<Componentes> _repositorioComponente;
    public ComponentesController(IRepositorio<Componentes> repositorioComponente)
    {
        _repositorioComponente = repositorioComponente;
    }
    // GET: api/Componentes
    [HttpGet]
    public IActionResult GetComponentes()
    {
        var componentes = _repositorioComponente.GetAll();
        if (componentes == null || !componentes.Any())
        {
            return NotFound("No se encontraron componentes.");
        }
        return Ok(componentes);
    }
    // GET: api/Componentes/5
    [HttpGet("{id}")]
    public IActionResult GetComponente(int id)
    {
        var componente = _repositorioComponente.Get(id);
        if (componente == null)
        {
            return NotFound();
        }
        return Ok(componente);
    }
    // PUT: api/Componentes/5
    
    [HttpPut("{id}")]
    public async Task<IActionResult> PutComponente(int id, [FromForm] Componentes componente)
    {
        if (id != componente.Id)
        {
            return BadRequest();
        }
        _repositorioComponente.Update(componente);
        return NoContent();
    }
    // POST: api/Componentes

    [HttpPost]
    public async Task<ActionResult<Componentes>> PostComponente([FromBody] Componentes componente)
    {
        if (_repositorioComponente.GetAll() == null)
        {
            return Problem("Entity set 'OrdenadoresContext.Componentes'  is null.");
        }
        _repositorioComponente.Create(componente);
        return CreatedAtAction(nameof(GetComponente), new { id = componente.Id }, componente);
    }
    // DELETE: api/Componentes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteComponente(int id)
    {
        if (_repositorioComponente.GetAll() == null)
        {
            return NotFound();
        }
        var componente = _repositorioComponente.Get(id);
        if (componente == null)
        {
            return NotFound();
        }
        _repositorioComponente.Delete(componente.Id);
        return NoContent();
    }
}