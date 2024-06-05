using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTarea_Domain.Entity;

namespace ApiTarea_infrastructure.Interface
{
    public interface IPersonaRepository
    {
        public Task<dynamic> getPersona();
        public Task AddPersonaAsync(Persona persona);  // Nuevo método
    }
}
