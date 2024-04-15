using Domian.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Interfaces;
using Task.Services;
using Util.Helpers;

namespace Facade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrestamoController : ControllerBase
    {
        private IConfiguration _configuration;
        private readonly IPrestamoServicio _prestamoServicio;

        public PrestamoController(IConfiguration configuration, IPrestamoServicio prestamoServicio)
        {
            _configuration = configuration;
            _prestamoServicio = prestamoServicio;
        }

        [HttpPost]
        public void Post([FromBody] Prestamo prestamo)
        {
            _prestamoServicio.RegistrarPrestamo(prestamo, Common.getSettings(_configuration));
        }

    }
}
