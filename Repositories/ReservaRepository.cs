using ReservaVuelo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservaVuelo;
using System.Collections;

namespace ReservaVuelo.Repositories
{
    //repositorio de reservas

    public class ReservaRepository
    {
       public List<ReservaDetalle> ObtenerReservasPorPasajero(int pasajeroId, bool futuras)
{
    var lista = new List<ReservaDetalle>();

    string query = @"SELECT r.ReservaID, r.NumeroVuelo, v.Origen, v.Destino, v.FechaSalida,
                            r.AsientoAsignado, r.EstadoReserva, r.FechaReserva
                     FROM Reservas r
                     INNER JOIN Vuelos v ON r.NumeroVuelo = v.NumeroVuelo
                     WHERE r.PasajeroID = @pasajeroId AND 
                           ((@futuras = 1 AND v.FechaSalida > GETDATE()) OR
                            (@futuras = 0 AND v.FechaSalida <= GETDATE()))";

    Database.Instance.Open();
    using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
    {
        cmd.Parameters.AddWithValue("@pasajeroId", pasajeroId);
        cmd.Parameters.AddWithValue("@futuras", futuras ? 1 : 0);

        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                var reserva = new ReservaDetalle
                {
                    ReservaID = reader.GetInt32(0),
                    NumeroVuelo = reader.GetString(1),
                    Origen = reader.GetString(2),
                    Destino = reader.GetString(3),
                    FechaSalida = reader.GetDateTime(4),
                    AsientoAsignado = reader.GetString(5),
                    EstadoReserva = reader.GetString(6),
                    FechaReserva = reader.GetDateTime(7)
                };
                lista.Add(reserva);
            }
        }
    }
    Database.Instance.Close();

    return lista;
    }

        public void CrearReserva(int pasajeroId, ReservaDetalle reserva)
        {
            string query = @"INSERT INTO Reservas (PasajeroID, NumeroVuelo, AsientoAsignado, EstadoReserva, FechaReserva)
                     VALUES (@pasajeroId, @numVuelo, @asiento, @estado, @fecha)";

            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@pasajeroId", pasajeroId);
                cmd.Parameters.AddWithValue("@numVuelo", reserva.NumeroVuelo);
                cmd.Parameters.AddWithValue("@asiento", reserva.AsientoAsignado);
                cmd.Parameters.AddWithValue("@estado", reserva.EstadoReserva);
                cmd.Parameters.AddWithValue("@fecha", reserva.FechaReserva);
                cmd.ExecuteNonQuery();
            }
            Database.Instance.Close();
        }


        public void CancelarReserva(int reservaId)
        {
            string query = "DELETE FROM Reservas WHERE ReservaID = @id";
            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@id", reservaId);
                cmd.ExecuteNonQuery();
            }
            Database.Instance.Close();
        }

    }
}
