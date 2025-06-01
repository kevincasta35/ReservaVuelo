using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaVuelo.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
    }
}
