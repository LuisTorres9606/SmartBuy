using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_SmartBuy.Models
{
    public class Producto
    {
        public int ID_PRODUCTO { get; set; }

        public string NOMBRE { get; set; }

        public string MARCA { get; set; }

        public string CATEGORIA { get; set; }

        public string DETALLE { get; set; }

        public decimal PRECIO { get; set; }

        public int CANTIDAD { get; set; }

        public byte[] FOTO { get; set; }
    }
}