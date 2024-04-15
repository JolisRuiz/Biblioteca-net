using Domian.Interfaces;
using Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Interfaces;

namespace Task.Services
{
    public class LibroServicio : ILibroServicio
    {
        private readonly ILibroRepositorio _repositorio;
        public LibroServicio(ILibroRepositorio repositorio) {
            _repositorio = repositorio;
        }

        public List<Libro> ListarLibros(EntAppConfig config)
        {
            return _repositorio.ListarLibros(config);
        }
    }
}
