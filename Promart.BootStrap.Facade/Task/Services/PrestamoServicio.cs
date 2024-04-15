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
    public class PrestamoServicio : IPrestamoServicio
    {
        private readonly IPrestamoRepositorio _repositorio;
        public PrestamoServicio(IPrestamoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public bool RegistrarPrestamo(Prestamo prestamos, EntAppConfig config)
        {
            return _repositorio.RegistrarPrestamo(prestamos, config);
        }
    }
}
