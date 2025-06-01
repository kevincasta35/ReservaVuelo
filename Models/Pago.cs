using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaVuelo.Models
{
    public class Pago
    {

        //Implementación modelo Pago para los pagos.
        public int PagoID { get; set; }
        public int ReservaID { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
