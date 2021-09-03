using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace Usuario
{
    [Database(Name = "SMARTBUY")]
    public class SmartBuy : DataContext
    {
        public SmartBuy() : base(Conexion.CadenaConexion) { }
        public Table<Usuario> Usuario;
    }
}