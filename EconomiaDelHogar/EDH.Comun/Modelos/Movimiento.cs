using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDH.Comun.Modelos
{
    internal class Movimiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Categoria Categoria { get; set; }
        public Subcategoria Subcategoria { get; set; }
        public string Descripcion { get; set; }
        public string FormaPago { get; set; }
        public Cuenta Cuenta { get; set; }


    }

}
