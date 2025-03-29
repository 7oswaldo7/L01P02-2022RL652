using System.ComponentModel.DataAnnotations;

namespace L01P02_2022RL652.Models
{
    public class Roles

    {
        [Key]

        public int rolId { get; set; }

        public string? rolNombre { get; set; }


    }
}
