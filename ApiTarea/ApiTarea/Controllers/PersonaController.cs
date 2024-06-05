/*manejan las solicitudes HTTP y coordinan las respuestas*/
using ApiTarea_Application.Interface;
using ApiTarea_Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarea.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _service;

        public PersonaController(IPersonaService service)
        {
            _service = service;
        }

        //metodo get que envia la lista de personas
        [HttpGet("getpersona")]
        public async Task<JsonResult> getPersona()
        { 
            return new JsonResult(await _service.getPersona());
        }

        //metodo post que realiza el envio para crear una nueva persona
        [HttpPost("addpersona")]
        public async Task<IActionResult> AddPersona([FromBody] Persona persona)
        {
            await _service.AddPersonaAsync(persona);
            return Ok();
        }
    }
        
}
