/*coordinan la ejecución de las operaciones de negocio y utilizan los repositorios para acceder a los datos.*/
using ApiTarea_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTarea_infrastructure.Interface;
using ApiTarea_infrastructure.Repository;
using ApiTarea_Domain.Entity;

namespace ApiTarea_Application.Service
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _repository;

        public PersonaService(IPersonaRepository repository)
        {
            _repository = repository;
        }

        public async Task<dynamic> getPersona()
        {
            return await _repository.getPersona();
        }

        public async Task AddPersonaAsync(Persona persona)
        {
            await _repository.AddPersonaAsync(persona);
        }


    }
}
