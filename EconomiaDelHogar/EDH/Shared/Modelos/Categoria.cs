using System.ComponentModel.DataAnnotations;

namespace EDH.Shared.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Nombre { get; set; }

        public string Icono { get; set; } // "bi bi-pencil-square"

    }
}
