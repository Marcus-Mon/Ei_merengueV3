using System.ComponentModel.DataAnnotations;

namespace EiMerengue.Server.Models
{
    public class Merenguero
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "El campo (0) tiene un maximo (1) de caracteres.")]
        public string Nombre { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "El campo (0) tiene un maximo (1) de caracteres.")]
        public string Descripcion { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "El campo (0) tiene un maximo (1) de caracteres.")]
        public string Nacimiento { get; set; } = null!;
    }
}
