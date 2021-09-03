using System;
using System.Linq;


namespace Usuario
{
    public class Service : IMetodos
    {
        SmartBuy DB_SmartBuy = new SmartBuy();

        public bool ValidarUsuario(string UserName)
        {
            bool Exist = false;

            try
            {
                if (DB_SmartBuy.Usuario.Single(Us => Us.USERNAME.Equals(UserName)) != null)
                {
                    Exist = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }            

            return Exist;
        }

        public bool AddClient(string Username, string Contraseña)
        {
            bool Exist = ValidarUsuario(Username);
            bool isCreate;

            if (!Exist)
            {
                Usuario NewUser = new Usuario { USERNAME = Username, PASSWORD = Contraseña, ESTADO = true,ID_ROL = "N" };
                DB_SmartBuy.Usuario.InsertOnSubmit(NewUser);
                DB_SmartBuy.SubmitChanges();

                isCreate = true;
            }
            else
            {
                isCreate = false;
            }
          

            return isCreate;
        }

        public void UpdateInfo(string Username, string Nombre, string Apellidos, string Cedula, string Direccion, string Telefono, string CorreoElectronico)
        {
            Usuario NewUser = DB_SmartBuy.Usuario.Single(Us => Us.USERNAME.Equals(Username));
            NewUser.NOMBRE = Nombre;
            NewUser.APELLIDOS = Apellidos;
            NewUser.CEDULA = Cedula;
            NewUser.DIRECCION = Direccion;
            NewUser.TELEFONO = Telefono;
            NewUser.CORREO_ELECTRONICO = CorreoElectronico;

            DB_SmartBuy.SubmitChanges();
        }

        public void StateChange(string Username)
        {
            bool Estado = false;

            Usuario NewUser = DB_SmartBuy.Usuario.Single(Us => Us.USERNAME.Equals(Username));
            NewUser.ESTADO = Estado;
            DB_SmartBuy.SubmitChanges();
        }

        public Usuario Login(string Username, string Contraseña)
        {
            Usuario NewUser = null;
            try
            {
                NewUser = DB_SmartBuy.Usuario.Single(Us => Us.USERNAME.Equals(Username) && Us.PASSWORD.Equals(Contraseña));
                return NewUser;

            }catch (Exception Ex)
            {
                Console.WriteLine("Error detectado: {0}", Ex);
                return NewUser;
            }
           
          ;
        }

        public Usuario ChangePassword(string UserName, string PassOld, string PassNew)
        {
            Usuario NewUser = DB_SmartBuy.Usuario.Single(Us => Us.USERNAME.Equals(UserName) && Us.PASSWORD.Equals(PassOld));
            NewUser.PASSWORD = PassNew;
            DB_SmartBuy.SubmitChanges();

            return NewUser;
        }
    }
}