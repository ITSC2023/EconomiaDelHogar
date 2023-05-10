using EDH.Shared.Models;

namespace EDH.Shared.Modelos
{
    public class Grupo
    {
        public int Id { get; set; }

        public int Nombre { get; set; }


        public int Codigo { get; set; }


        public List<ApplicationUser> Usuarios { get; set; }

    }
}
