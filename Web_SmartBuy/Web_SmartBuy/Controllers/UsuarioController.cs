using System;
using System.Web.Mvc;
using Web_SmartBuy.Models;

namespace Web_SmartBuy.Controllers
{
    public class UsuarioController : Controller
    {
        Service_User.MetodosClient BD_Servicio = new Service_User.MetodosClient();

        public ActionResult Index()
        {
            return View();
        }

        protected bool ConvertUser (Service_User.Usuario WSUser)
        {
            if (WSUser != null)
            {
                Usuario NewUser = new Usuario
                {
                    USERNAME = WSUser.USERNAME,
                    PASSWORD = WSUser.PASSWORD,
                    NOMBRE = WSUser.NOMBRE,
                    APELLIDOS = WSUser.APELLIDOS,
                    CEDULA = WSUser.CEDULA,
                    TELEFONO = WSUser.TELEFONO,
                    CORREO_ELECTRONICO = WSUser.CORREO_ELECTRONICO,
                    DIRECCION = WSUser.DIRECCION,
                    ROL = WSUser.ID_ROL
                };
                if (Session["Usuario"] != null)
                {
                    Session.Remove("Usuario");
                    Session.Add("Usuario", NewUser);
                }
                else
                {
                    Session["Usuario"] = NewUser;
                }

                return true;
                
            }
            return false;
        }

        [HttpPost]
        public ActionResult Login(string Usuario,string Contrasenia)
        {
           if(ConvertUser(BD_Servicio.Login(Usuario,Contrasenia)))
                    return RedirectToAction("Productos", "Productos");
            else
            {
                TempData.Add("ErrorLogin","Usuario O Contraseña Incorrectos");
                return RedirectToAction("Index","Home");               
            }            
        }

        
        public ActionResult CerrarSesion()
        {
            if (Session != null)
            {
                Session.Remove("Usuario");
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult CreateUser(string Usuario, string Contrasenia, string Contraseniav)
        {
            if (Contrasenia.Equals(Contraseniav))
            {
                if (BD_Servicio.AddClient(Usuario, Contrasenia))
                {
                     ConvertUser(BD_Servicio.Login(Usuario, Contrasenia));
                    
                }
                return RedirectToAction("MiCuenta", "Usuario");
            }
            else
            {
                TempData.Add("ErrorSignIn", "Las contraseñas no coinciden");
                return RedirectToAction("Index", "Home");
            }
            
        }

        
        public ActionResult MiCuenta(string Nombre, string Apellidos, string Cedula, string Email, string Telefono, string Direccion, string Button)
        {
            ViewBag.Message = "Actualiza Tus Datos";
            if (Session["Usuario"] != null)
            {
                if (Button == "true")
                {
                    var User = (Usuario)Session["Usuario"];
                    BD_Servicio.UpdateInfo(User.USERNAME, Nombre, Apellidos, Cedula, Direccion, Telefono, Email);
                    ConvertUser(BD_Servicio.Login(User.USERNAME, User.PASSWORD));

                    return View();
                }
                return View();

            }
            else
            {
                return RedirectToAction("Error", "Home");
            }                        
        }
    }
}