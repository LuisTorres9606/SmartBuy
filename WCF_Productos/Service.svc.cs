using System;
using System.Collections.Generic;
using System.Linq;
using Productos.Models;

namespace Productos
{
    public class Service : IMetodos
    {
        SmartBuy DB_SmartBuy = new SmartBuy();

        public void NuevoProducto(string Nombre, string Marca, string Categoria, string Detalle, decimal precio, int Cantidad, byte[] Foto)
        {
            Producto NewProducto = new Producto
            {
                NOMBRE = Nombre,
                MARCA = Marca,
                CATEGORIA  = Categoria,
                DETALLE = Detalle,
                PRECIO = precio,
                CANTIDAD = Cantidad,
                FOTO = Foto
            };

            DB_SmartBuy.Productos.InsertOnSubmit(NewProducto);
            DB_SmartBuy.SubmitChanges();
        }

        public void Modificar(int Idproducto, string Nombre, string Marca, string Categoria, string Detalle, decimal Precio, int Cantidad, byte[] Foto)
        {
            Producto NewProducto = DB_SmartBuy.Productos.Single(Prod => Prod.ID_PRODUCTO == Idproducto);

            NewProducto.NOMBRE = Nombre;
            NewProducto.MARCA = Marca;
            NewProducto.CATEGORIA = Categoria;
            NewProducto.DETALLE = Detalle;
            NewProducto.PRECIO = Precio;
            NewProducto.CANTIDAD = Cantidad;
            NewProducto.FOTO = Foto;
        }

        public List<Producto> BuscarProducto(string Nombre)
        {
            var Consulta = DB_SmartBuy.Productos.Where(Prod => Prod.NOMBRE.Contains(Nombre)).ToList();

            return Consulta;
        }

        public List<Producto> ProductosMarca(string Marca)
        {
            if(Marca == null)
                    Marca = "";

            var Consulta = DB_SmartBuy.Productos.Where(Prod => Prod.MARCA.Contains(Marca)).ToList();


            return Consulta;
        }

        public List<Producto> ProductosCategoria(string Categoria)
        {
            if(Categoria == null)
                    Categoria = "";

            var Consulta = DB_SmartBuy.Productos.Where(Prod => Prod.CATEGORIA.Contains(Categoria)).ToList();


            return Consulta;
        }

        public List<Marca> Marcas()
        {
            var Consulta = DB_SmartBuy.Marca.OrderBy(M => M.NOMBRE_MARCA).ToList();
            
            return Consulta;
        }

        public Producto BusquedaId(int Id_producto)
        {
            var Producto = DB_SmartBuy.Productos.Single(P => P.ID_PRODUCTO == Id_producto);

            return Producto;
        }
    }
}
