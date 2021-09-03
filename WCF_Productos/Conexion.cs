using System.Configuration;

namespace Productos.Models
{
    public class Conexion
    {        public static string CadenaConexion
        {
            get
            {
                return
                  ConfigurationManager.ConnectionStrings["CadenaConexion"]
                  .ConnectionString.ToString();
            }
        }
    }
}