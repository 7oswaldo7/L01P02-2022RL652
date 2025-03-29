using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace L01P02_2022RL652.Models
{
    public class Publicaciones
    {
        [Key]

        public int publicacionId { get; set; }  
        
        public string? titulo { get; set; }

        public string? descripcion { get; set; }

        public int usuarioId { get; set; }

    }
}
