using System.ComponentModel.DataAnnotations;

namespace ApiTarea.Model
{
    public class Persona
    {
        [Key]

        public int PersonaID { get; set; }
        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public string telefono { get; set; }
    }
}
