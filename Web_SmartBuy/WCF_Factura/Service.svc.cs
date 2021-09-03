using System;
using System.Collections.Generic;
using System.Linq;
using WCF_Factura.Models;

namespace WCF_Factura
{
    
    public class Service : IMetodos
    {
        SmartBuy DB_SmartBuy = new SmartBuy();

        public bool AgregarItem(WishList Item)
        {
            try
            {
                WishList NewItem = Item;
                DB_SmartBuy.WishList.InsertOnSubmit(NewItem);
                DB_SmartBuy.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public List<WishList> ConsultarLista(string UserName)
        {
            var Consulta = DB_SmartBuy.WishList.Where(Wish => Wish.USERNAME == UserName).ToList();

            return Consulta;
        }
    }
}
