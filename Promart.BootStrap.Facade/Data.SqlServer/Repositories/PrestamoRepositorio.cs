using Domian.Interfaces;
using Domian.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SqlServer.Repositories
{
    public class PrestamoRepositorio : IPrestamoRepositorio
    {
        public bool RegistrarPrestamo(Prestamo prestamo, EntAppConfig config)
        {
            using (SqlConnection sql = new SqlConnection(config.SqlServerConnection))
            {
                using (SqlCommand cmd = new SqlCommand("Biblioteca.CrearPrestamo", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@pUsuarioId", prestamo.Usuario.UsuarioId));
                    cmd.Parameters.Add(new SqlParameter("@pFechaPrestamo", prestamo.FechaPrestamo));
                    cmd.Parameters.Add(new SqlParameter("@pFechaDevolucion", prestamo.FechaDevolucion));
                    cmd.Parameters.Add(new SqlParameter("@pEstadoPrestamoId", prestamo.EstadoPrestamo.EstadoPrestamoId));
                    cmd.Parameters.Add(new SqlParameter("@pBibliotecarioId", prestamo.Bibliotecario.UsuarioId));
                    cmd.Parameters.Add(new SqlParameter("@pLibroId", prestamo.DetallePrestamo.Libro.LibroId));
                    cmd.Parameters.Add(new SqlParameter("@pCantidad", prestamo.DetallePrestamo.Cantidad));

                    sql.Open();
                    cmd.ExecuteNonQuery();
                    sql.Close();
                    return true;
                }
            }
        }
    }
}
