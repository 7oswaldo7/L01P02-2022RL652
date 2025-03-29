using System.ComponentModel.DataAnnotations;

namespace L01P02_2022RL652.Models
{
    public class Comentarios
    {
        [Key]

        public int comentarioId { get; set; }

        public int publicacionId { get; set; }

        public string? comentario { get; set; }

        public int usuarioId { get; set; }
    }
}
