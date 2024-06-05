using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTarea_Domain.Entity;

namespace ApiTarea_Application.Interface
{
    public interface IPersonaService
    {
        public Task<dynamic> getPersona();
        Task AddPersonaAsync(Persona persona);
    }
}
