using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace WCF_Factura.Models
{
    [Table(Name = "WISHLIST")]
    public class WishList
    {
        [Column (IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID_WISH { get; set; }

        [Column]
        public string USERNAME { get; set; }

        [Column]
        public int ID_PRODUCTO { get; set; }

        [Column]
        public string NOMBRE { get; set; }

        [Column]
        public string MARCA { get; set; }

        [Column]
        public int CANTIDAD { get; set; }

        [Column]
        public decimal PRECIO { get; set; }

        [Column]
        public decimal TOTAL { get; set; }
    }
}