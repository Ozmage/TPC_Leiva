using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Presupuesto : Persona
    {
        public int IdPresupuesto { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaPresupuesto { get; set;}
        public DateTime FechaVencimiento { get; set; }

        public string Detalle { get; set; }
        public string CodDesc { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public int IdVersion { get; set; }
        public string Patente { get; set; }
        public string CeroKm { get; set; }
        public int Anio { get; set; }
        public string GncGas { get; set; }
        public string FormaDePago { get; set; }   //Efectivo, tarjeta, transferencia,mercadolibre, etc
        public int EstadoPresupuesto { get; set; }


    }
}
