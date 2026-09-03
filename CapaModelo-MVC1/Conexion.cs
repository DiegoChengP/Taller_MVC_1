using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC1
{
    class Conexion
    {
        public OdbcConnection conexion()
           { 
            OdbcConnection conn = new OdbcConnection("Dsn=umg_taller");
            try
            {
                conn.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error de conexion");
            }
            return conn;
        }
        public void desconexion(OdbcConnection conn)
            {
                try
                {
                    conn.Close();
                    Console.WriteLine("Conexion cerrada");
                }
                catch (OdbcException)
                {
                    Console.WriteLine("Error al cerrar la conexion");
                }
        }
    }
}
