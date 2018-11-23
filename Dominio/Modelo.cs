using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Modelo 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreMarca { get; set; }
        public int IdMarca { get; set; }
        public int Estado { get; set; }
    }
}
