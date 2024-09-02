using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Pais_Ciudad.Config
{
    internal class Conexion
    {
        private static readonly string connectionString;

        static Conexion()
        {
            // Aquí puedes establecer tu cadena de conexión. Se recomienda obtenerla de un archivo de configuración o variables de entorno.
            connectionString = "Server=ALEXIA\\SQLEXPRESS;database=Ciudade_Paises;uid=sa;pwd=2023022;";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                throw;
            }
        }
    }
}
