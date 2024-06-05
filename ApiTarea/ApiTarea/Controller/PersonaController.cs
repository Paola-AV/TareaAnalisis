using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTarea.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTarea.Controller
{
    [Route("api/Personas")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        private readonly UserDbContext _context;

        public PersonaController(UserDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("GetPedido")]

        public async Task<IEnumerable<Persona>> GetPedido()
        {
            return await _userDbContext.Pedidos.ToListAsync();

        }


        [HttpPost]
        [Route("AddPedido")]

        public async Task<Pedido> AddPedido(Pedido objPedido)
        {
            _userDbContext.Pedidos.Add(objPedido);
            await _userDbContext.SaveChangesAsync();
            return objPedido;
        }

    }
}
