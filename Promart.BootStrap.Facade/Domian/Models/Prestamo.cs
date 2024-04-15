using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Models
{
    public class Prestamo
    {
        [Key]
        public int PrestamoId { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public EstadoPrestamo EstadoPrestamo { get; set; }
        public Usuario Bibliotecario { get; set; }
        public bool Estado { get; set; }
        public DetallePrestamo DetallePrestamo { get; set; }
    }
}
