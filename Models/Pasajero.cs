using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaVuelo.Models
{
    public class Pasajero
    {
        public int PasajeroID { get; set; }
        public string Nombre { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
