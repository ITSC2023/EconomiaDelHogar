using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDH.Shared.Modelos
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string BancoEmisor { get; set; }
        public Divisa Divisa { get; set; }
        public decimal Saldo { get; set; }

    }
}
