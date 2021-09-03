using System;
using System.Data.Linq.Mapping;


namespace Usuario
{
    [Table(Name = "USUARIOS")]
    public class Usuario
    {
        [Column(IsPrimaryKey =true)]
        public string USERNAME { get; set; }

        [Column]
        public string PASSWORD { get; set; }

        [Column]
        public string NOMBRE { get; set; }

        [Column]
        public string APELLIDOS { get; set; }

        [Column]
        public string CEDULA { get; set; }

        [Column]
        public string DIRECCION { get; set; }

        [Column]
        public string TELEFONO { get; set; }

        [Column]
        public string CORREO_ELECTRONICO { get; set; }

        [Column]
        public bool ESTADO { get; set; }

        [Column]
        public String ID_ROL { get; set; }

    }
}