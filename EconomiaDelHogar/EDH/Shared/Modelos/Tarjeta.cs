using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDH.Comun.Modelos
{
    internal class Tarjeta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string EnteEmisor { get; set; }
        public DateTime Cierre { get; set; }
        public DateTime? VencimientoResumen { get; set; }
        public decimal Importe { get; set; }
        private string NroTarjeta { get; set; }
    }
}
