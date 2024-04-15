using Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Interfaces
{
    public interface ILibroRepositorio
    {
        List<Libro> ListarLibros(EntAppConfig config);
    }
}
