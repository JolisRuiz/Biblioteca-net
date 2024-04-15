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
    public class LibroRepositorio : ILibroRepositorio
    {
        public List<Libro> ListarLibros(EntAppConfig config)
        {
            using (SqlConnection sql = new SqlConnection(config.SqlServerConnection))
            {
                using (SqlCommand cmd = new SqlCommand("Biblioteca.ListarLibros", sql))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    var response = new List<Libro>();
                    sql.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        response.Add(MapearLibros(reader));
                    }

                    return response;
                }
            }
        }

        private Libro MapearLibros(SqlDataReader reader)
        {
            return new Libro()
            {
                LibroId = (int)reader["LibroId"],
                Titulo = reader["Titulo"].ToString(),
                Descripcion = reader["Descripcion"].ToString(),
                Estado = (bool)reader["Estado"],
                Categoria = new Categoria()
                {
                    CategoriaId = (int)reader["CategoriaId"],
                    Nombre = reader["NombreCategoria"].ToString(),
                    Estado = (bool)reader["EstadoCategoria"]
                },
                Autor = new Autor()
                {
                    AutorId = (int)reader["AutorId"],
                    Nombre = reader["NombreAutor"].ToString(),
                    Estado = (bool)reader["EstadoAutor"]
                }
            };
        }

    }
}
