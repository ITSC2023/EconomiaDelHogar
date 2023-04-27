﻿namespace EDH.Shared.Modelos
{
    public class Movimiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Categoria Categoria { get; set; }
        public Subcategoria Subcategoria { get; set; }
        public string Descripcion { get; set; }
        public string FormaPago { get; set; }
        public decimal Importe { get; set; }

        public Cuenta Cuenta { get; set; }


    }

}
