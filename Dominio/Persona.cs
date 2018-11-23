using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string PisoPlanta { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Telefono { get; set; }
        public string CodPostal { get; set; }
        public int DNI { get; set; }
        public int EstadoPersona { get; set; }

        

    }
}
