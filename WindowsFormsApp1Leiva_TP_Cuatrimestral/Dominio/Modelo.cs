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
        public int IdMarca { get; set; }
        public string Name { get; set; }
        //public int VDP { get; set; }
        //  public int Estado { get; set; }

        public Modelo() { }
        public Modelo(int id, int idMarca, string name)
        //public Modelo(int id, int idMarca, string name, int vdp, int estado)
        {
            Id = id;
            IdMarca = idMarca;
            Name = name;
            // VDP = vdp;
            // Estado = estado;
        }
    }
}
