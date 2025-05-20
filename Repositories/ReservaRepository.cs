using ReservaVuelo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaVuelo.Repositories
{
    //repositorio de reservas
    using ReservaVuelo;
    public class ReservaRepository
    {
        public List<ReservaDetalle> ObtenerReservasPorPasajero(int pasajeroId, bool futuras)
        {
            var lista = new List<ReservaDetalle>();
            string condicion = futuras ? "FechaSalida >= GETDATE()" : "FechaSalida < GETDATE()";

            string query = $@"
        SELECT v.NumeroVuelo, v.Origen, v.Destino, v.FechaSalida, r.AsientoAsignado, r.EstadoReserva
        FROM Reservas r
        INNER JOIN Vuelos v ON r.VueloID = v.VueloID
        WHERE r.PasajeroID = @pasajeroId AND v.{condicion}";

            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@pasajeroId", pasajeroId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new ReservaDetalle
                        {
                            NumeroVuelo = reader["NumeroVuelo"].ToString(),
                            Origen = reader["Origen"].ToString(),
                            Destino = reader["Destino"].ToString(),
                            FechaSalida = (DateTime)reader["FechaSalida"],
                            AsientoAsignado = reader["AsientoAsignado"].ToString(),
                            EstadoReserva = reader["EstadoReserva"].ToString()
                        });
                    }
                }
            }
            Database.Instance.Close();
            return lista;
        }
    }
}
