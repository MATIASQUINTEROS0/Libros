using System.ComponentModel.DataAnnotations;

namespace GestionLibros.API.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;

        public int Anio { get; set; }
    }
}
