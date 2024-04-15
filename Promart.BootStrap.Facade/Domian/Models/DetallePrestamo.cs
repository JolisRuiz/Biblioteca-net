using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Models
{
    public class DetallePrestamo
    {
        public int DetallePrestamoId { get; set; }
        public Libro Libro { get; set; }
        public int Cantidad { get; set; }
        public bool Estado { get; set; }
    }
}
