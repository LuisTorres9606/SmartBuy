using System.Data.Linq.Mapping;
using System.Data.Linq;
using Productos.Models;

namespace Productos
{
    [Database(Name = "SMARTBUY")]
    public class SmartBuy: DataContext
    {
        public SmartBuy() : base(Conexion.CadenaConexion) { }
        public Table<Producto> Productos;
        public Table<Marca> Marca;
    }
}