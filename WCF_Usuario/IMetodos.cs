using System.ServiceModel;

namespace Usuario
{
    [ServiceContract]
    interface IMetodos
    {
        [OperationContract]
        bool AddClient(string Username, string Password);

        [OperationContract]
        void UpdateInfo(string Username, string Nombre, string Apellidos,
                        string Cedula, string Direccion, string Telefono,
                        string CorreoElectronico);

        [OperationContract]
        void StateChange(string Username);

        [OperationContract]
        Usuario Login(string Username, string Password);

        [OperationContract]
        Usuario ChangePassword(string UserName, string PassOld, string PassNew);
    }
}
