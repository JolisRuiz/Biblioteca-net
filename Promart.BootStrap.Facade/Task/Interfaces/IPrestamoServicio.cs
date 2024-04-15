using Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Interfaces
{
    public interface IPrestamoServicio
    {
        bool RegistrarPrestamo(Prestamo prestamos, EntAppConfig config);
    }
}
