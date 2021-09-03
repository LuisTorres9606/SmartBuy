using System.Data.Linq.Mapping;

namespace Productos
{
    [Table(Name = "PRODUCTOS")]
    public class Producto
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID_PRODUCTO { get; set; }

        [Column]
        public string NOMBRE { get; set; }

        [Column]
        public string MARCA { get; set; }

        [Column]
        public string CATEGORIA { get; set; }

        [Column]
        public string DETALLE { get; set; }

        [Column]
        public decimal PRECIO { get; set; }

        [Column]
        public int CANTIDAD { get; set; }

        [Column]
        public byte[] FOTO { get; set; }
    }
}