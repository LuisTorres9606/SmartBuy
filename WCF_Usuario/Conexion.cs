using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Usuario
{
    public class Conexion
    {
        public static string CadenaConexion
        {
            get {
                return ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString.ToString();
            }
        }
    }
}