using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaVuelo.Models
{
    public class ReservaDetalle
    {
        public string NumeroVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public string AsientoAsignado { get; set; }
        public string EstadoReserva { get; set; }
    }
}
