using System;

namespace ReservaVuelo.Models
{
    public class ReservaDetalle
    {
        public int ReservaID { get; set; }
        public string NumeroVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public string AsientoAsignado { get; set; }
        public string EstadoReserva { get; set; }
        public DateTime FechaReserva { get; set; } // NUEVA propiedad
    }
}
