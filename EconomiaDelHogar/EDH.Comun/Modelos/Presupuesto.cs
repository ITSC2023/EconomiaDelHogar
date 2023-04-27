using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDH.Comun.Modelos
{
    internal class Presupuesto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }
        public Divisa Divisa { get; set; }
        public decimal Monto { get; set; }
        public List<Categoria> Categorias { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCierre { get; set; }
    }
}
