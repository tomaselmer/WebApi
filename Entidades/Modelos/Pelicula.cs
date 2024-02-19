using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Genre { get; set; }
        public string? Description { get; set; }
    }
}
