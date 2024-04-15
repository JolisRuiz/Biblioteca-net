using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Models
{
    public class Libro
    {
        [Key]
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categoria { get; set; }
        public Autor Autor { get; set; }
        public bool Estado { get; set; }
    }
}
