using System.Data.Linq.Mapping;

namespace Productos.Models
{
    [Table(Name = "MARCA")]
    public class Marca
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID_MARCA { get; set; }

        [Column]
        public string NOMBRE_MARCA { get; set; }
    }
}