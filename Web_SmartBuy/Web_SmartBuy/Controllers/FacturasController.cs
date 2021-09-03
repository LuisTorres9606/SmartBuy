using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using Web_SmartBuy.Models;

namespace Web_SmartBuy.Controllers
{
    public class FacturasController : Controller
    {
        cr.fi.bccr.gee.wsindicadoreseconomicosSoapClient BCCR = new cr.fi.bccr.gee.wsindicadoreseconomicosSoapClient();
        Service_Factura.MetodosClient BD_Servicio = new Service_Factura.MetodosClient();

        public double TipoDeCambio()
        {
            string FechaActual = DateTime.Today.ToString("dd/MM/yyyy");
            double MontoDolar;

            DataSet TipoDolar = BCCR.ObtenerIndicadoresEconomicos("318", FechaActual, FechaActual, "Fernando", "N", "Ltorres96@outlook.es", "5R3MS2TN23");
            MontoDolar = Convert.ToDouble(TipoDolar.Tables[0].Rows[0][2]);

            return MontoDolar;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MiCarrito()
        {
            Usuario U = (Usuario)Session["Usuario"];
            var list = BD_Servicio.ConsultarLista(U.USERNAME);
            List<WishList> Micarrito = new List<WishList>();

            foreach (var item in list)
            {
                WishList Item = new WishList
                {
                    ID_WISH = item.ID_WISH,
                    USERNAME = U.USERNAME,
                    ID_PRODUCTO = item.ID_PRODUCTO,
                    NOMBRE = item.NOMBRE,
                    MARCA = item.MARCA,
                    CANTIDAD = item.CANTIDAD,
                    PRECIO = Math.Floor(item.PRECIO * Convert.ToDecimal(TipoDeCambio())),
                    TOTAL = Math.Floor(item.TOTAL * Convert.ToDecimal(TipoDeCambio())),
                };

                Micarrito.Add(Item);
            }

            ViewBag.Carrito = Micarrito;


            return View();
        }
    }
}