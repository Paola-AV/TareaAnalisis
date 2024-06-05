/*representan los objetos de negocio y las reglas de negocio fundamentales.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTarea_Domain.Entity
{
    public class Persona
    {
        //datos que pasaran a traves de la api a la base de datos en la tabla Personas
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
    }
}
