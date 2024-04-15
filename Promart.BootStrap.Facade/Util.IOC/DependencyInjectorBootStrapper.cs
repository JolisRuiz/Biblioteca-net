using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Interfaces;
using Task.Services;
using Domian.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Data.SqlServer.Repositories;

namespace Util.IOC
{
    public  class DependencyInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            //// Services
            services.AddScoped<ILibroServicio, LibroServicio>();
            services.AddScoped<IPrestamoServicio, PrestamoServicio>();

            //// Repository
            services.AddScoped<ILibroRepositorio, LibroRepositorio>();
            services.AddScoped<IPrestamoRepositorio, PrestamoRepositorio>();
        }
    }
}
