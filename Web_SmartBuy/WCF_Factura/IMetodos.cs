using System.Collections.Generic;
using System.ServiceModel;
using WCF_Factura.Models;

namespace WCF_Factura
{
    [ServiceContract]
    public interface IMetodos
    {

        [OperationContract]
        bool AgregarItem(WishList Item);

        [OperationContract]
        List<WishList> ConsultarLista(string UserName);

        // TODO: Add your service operations here
    }

}
