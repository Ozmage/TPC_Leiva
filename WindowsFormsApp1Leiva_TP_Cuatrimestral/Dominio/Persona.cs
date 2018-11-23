using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        //constructor 
        public Persona() { }
        public Persona(int id, string nombres, string apellido, string email)
        {
            Id = id;
            Nombres = nombres;
            Apellido = apellido;
            Email = email;
        }
    }
}
