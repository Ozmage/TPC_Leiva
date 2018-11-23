using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PresupuestoXCliente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdPresupuesto { get; set; }
        public int Estado { get; set; }
    }
}
