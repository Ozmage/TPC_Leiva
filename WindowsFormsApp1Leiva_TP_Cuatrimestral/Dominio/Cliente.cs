using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Persona
    {
        public Cliente(int id, string nombres, string apellido, string email)
            : base(id, nombres, apellido, email)
        {

        }
    }
}
