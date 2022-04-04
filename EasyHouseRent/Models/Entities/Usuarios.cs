using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyHouseRent.Model.Entities
{
    public class Usuarios
    {
        public int idusuario { set; get; }
        public string nombre { set; get; }
        public string apellidos { set; get; }
        public int edad { set; get; }
        public string telefono { set; get; }
        public string email { set; get; }
        public string contraseņa { set; get; }
        public string estado { set; get; }
        public int departamento { set; get; }
        public int municipio { set; get; }
    }
}