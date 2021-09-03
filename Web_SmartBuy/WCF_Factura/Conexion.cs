using System.Configuration;

namespace WCF_Factura
{
    public class Conexion
    {
        public static string CadenaConexion
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