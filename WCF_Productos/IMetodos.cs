using Productos.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace Productos
{
    [ServiceContract]
    interface IMetodos
    {
        [OperationContract]
        void NuevoProducto(string Nombre,string Marca,string Categoria,string Detalle, decimal precio,int Cantidad,byte[] Foto);

        [OperationContract]
        void Modificar(int Idproducto, string Nombre, string Marca, string Categoria,string Detalle, decimal precio, int Cantidad, byte[] Foto);

        [OperationContract]
        List<Producto> BuscarProducto(string Nombre);

        [OperationContract]
        List<Producto> ProductosMarca(string Marca);

        [OperationContract]
        List<Producto> ProductosCategoria(string Categoria);

        [OperationContract]
        List<Marca> Marcas();

        [OperationContract]
        Producto BusquedaId(int Id_producto);
    }
}
