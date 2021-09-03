using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_SmartBuy.Models
{
    public class WishList
    {
        public int ID_WISH { get; set; }

        public string USERNAME { get; set; }

        public int ID_PRODUCTO { get; set; }

        public string NOMBRE { get; set; }

        public string MARCA { get; set; }

        public int CANTIDAD { get; set; }

        public decimal PRECIO { get; set; }

        public decimal TOTAL { get; set; }
    }
}