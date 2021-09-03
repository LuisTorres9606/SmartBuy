
using System.ComponentModel.DataAnnotations;

namespace Web_SmartBuy.Models
{
    public class Usuario
    {

        public string USERNAME { get; set; }
       
        public string PASSWORD { get; set; }
       
        public string NOMBRE { get; set; }
       
        public string APELLIDOS { get; set; }
      
        public string CEDULA { get; set; }
       
        public string DIRECCION { get; set; }
        
        public string TELEFONO { get; set; }
       
        public string CORREO_ELECTRONICO { get; set; }
              
        public bool ESTADO { get; set; }

        public string ROL { get; set; }
    }
}