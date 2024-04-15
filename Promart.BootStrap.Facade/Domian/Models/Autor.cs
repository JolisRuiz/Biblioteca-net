using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Models
{
    public class Autor
    {
        [Key]
        public int AutorId { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
    }
}
