using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Web_SmartBuy.Models;

namespace Web_SmartBuy.Controllers
{
    public class ProductosController : Controller
    {
        cr.fi.bccr.gee.wsindicadoreseconomicosSoapClient BCCR = new cr.fi.bccr.gee.wsindicadoreseconomicosSoapClient();

        Service_Product.MetodosClient BD_Producto = new Service_Product.MetodosClient();
        Service_Factura.MetodosClient BD_Factura = new Service_Factura.MetodosClient();

        public void Marcas()
        {
            var Marcas = BD_Producto.Marcas();
            List<Marca> ListaMarca = new List<Marca>();

            for (int i = 0; i < Marcas.Length; i++) {
                Marca NewMarca = new Marca
                {
                    ID_MARCA = Marcas[i].ID_MARCA,
                    NOMBRE = Marcas[i].NOMBRE_MARCA
                };

                ListaMarca.Add(NewMarca);
            }

            if (TempData["Marcas"] != null)
            {
                TempData.Remove("Marcas");
                TempData.Add("Marcas", ListaMarca);
            }
            else
            {
                TempData.Add("Marcas", ListaMarca);
            }
        }

        public void TipoDeCambio()
        {
            string FechaActual = DateTime.Today.ToString("dd/MM/yyyy");
            double MontoDolar;

            DataSet TipoDolar = BCCR.ObtenerIndicadoresEconomicos("318", FechaActual, FechaActual, "Fernando", "N", "Ltorres96@outlook.es", "5R3MS2TN23");
            MontoDolar = Convert.ToDouble(TipoDolar.Tables[0].Rows[0][2]);

              if (Session["TipoCambio"] == null)
              {
                 Session.Add("TipoCambio", MontoDolar);
              }

            Console.WriteLine(FechaActual);
        }

        public ActionResult Productos()
        { 
            ViewBag.Message = "Productos Disponibles";

            return View();
        }

        public ActionResult Marca(String Marca)
        {

            if (Marca == "")
            {
                Marca = "Todas Las Marcas";
            }
            ViewBag.Message = Marca;

            TipoDeCambio();
            var Productos = BD_Producto.ProductosMarca(Marca);

            List<Producto> ProductosMarca = new List<Producto>();
            double TipoCambio = (double)Session["TipoCambio"];

            foreach (var item in Productos)
            {
                Producto NewProducto = new Producto
                {
                    ID_PRODUCTO = item.ID_PRODUCTO,
                    NOMBRE = item.NOMBRE,
                    MARCA = item.MARCA,
                    CATEGORIA = item.CATEGORIA,
                    DETALLE = item.DETALLE,
                    PRECIO = Math.Floor(Convert.ToDecimal(TipoCambio) * item.PRECIO),
                    CANTIDAD = item.CANTIDAD,
                    FOTO = item.FOTO
                };

                ProductosMarca.Add(NewProducto);
            }
            

            TempData.Add("ProductosMarca", ProductosMarca);            

            return View();
        }

        public ActionResult Categoria(String Categoria)
        {

            if (Categoria == "")
            {
                Categoria = "Todas Las Categorias";
            }
            ViewBag.Message = Categoria;

            TipoDeCambio();
            var Productos = BD_Producto.ProductosCategoria(Categoria);

            List<Producto> ProductosCategoria = new List<Producto>();
            double TipoCambio = (double)Session["TipoCambio"];

            foreach (var item in Productos)
            {
                Producto NewProducto = new Producto
                {
                    ID_PRODUCTO = item.ID_PRODUCTO,
                    NOMBRE = item.NOMBRE,
                    MARCA = item.MARCA,
                    CATEGORIA = item.CATEGORIA,
                    DETALLE = item.DETALLE,
                    PRECIO = Math.Floor(Convert.ToDecimal(TipoCambio) * item.PRECIO),
                    CANTIDAD = item.CANTIDAD,
                    FOTO = item.FOTO
                };

                ProductosCategoria.Add(NewProducto);
            }


            TempData.Add("ProductosCategoria", ProductosCategoria);

            return View();
        }

        public ActionResult AgregarProducto(string button,string IdProducto,string Nombre,string Marca, string Categoria, string Detalle, string Precio,string Cantidad, HttpPostedFileBase Imagen)
        {
            ViewBag.Message = "Agregar Producto";
            Marcas();

            Usuario User = (Usuario)Session["Usuario"];

            if(User != null && User.ROL == "A")
            {
                if (button == "true")
                {
                    try
                    {
                        WebImage ImaProducto = new WebImage(Imagen.InputStream);
                        BD_Producto.NuevoProducto(Nombre, Marca, Categoria, Detalle, Convert.ToDecimal(Precio), Convert.ToInt32(Cantidad), ImaProducto.GetBytes());

                        TempData.Add("ExitoProducto", "El producto se ha insertado en la Base de Datos Satisfactoriamente");
                    }
                    catch (Exception)
                    {

                        TempData.Add("ErrorProducto", "El producto se ha tenido un error al entrar a la Base de Datos");
                    }
                }

                return View();
            }
            else
            {
                return RedirectToAction("Error","Home");
            }   
        }

        public ActionResult WishList(string IdProducto, string Cantidad)
        {
            Usuario User = (Usuario)Session["Usuario"];
            var Pro = BD_Producto.BusquedaId(Convert.ToInt32(IdProducto));
            
            Service_Factura.WishList Item = new Service_Factura.WishList
            {
                USERNAME = User.USERNAME,
                ID_PRODUCTO = Pro.ID_PRODUCTO,
                NOMBRE = Pro.NOMBRE,
                MARCA = Pro.MARCA,
                CANTIDAD = Convert.ToInt32(Cantidad),
                PRECIO = Pro.PRECIO,
                TOTAL = Convert.ToDecimal(Cantidad) * Pro.PRECIO
            };

            BD_Factura.AgregarItem(Item);

            return RedirectToAction("MiCarrito", "Facturas");
        }
    }
}