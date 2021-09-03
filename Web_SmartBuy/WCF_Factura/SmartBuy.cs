using System.Data.Linq;
using System.Data.Linq.Mapping;
using WCF_Factura.Models;

namespace WCF_Factura
{
    [Database(Name = "SMARTBUY")]
    public class SmartBuy : DataContext
    {
        public SmartBuy() : base(Conexion.CadenaConexion) { }
        public Table<WishList> WishList;
    }
}