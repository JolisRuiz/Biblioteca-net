using Domian.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Interfaces;
using Util.Helpers;

namespace Facade.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibroController : ControllerBase
    {
        private IConfiguration _configuration;
        private readonly ILibroServicio _servicio;

        public LibroController(ILibroServicio servicio, IConfiguration configuration)
        {
            _configuration = configuration;
            _servicio = servicio;
        }

        [HttpGet]
        public List<Libro> Listar()
        {
            return _servicio.ListarLibros(Common.getSettings(_configuration));
        }
    }
}
