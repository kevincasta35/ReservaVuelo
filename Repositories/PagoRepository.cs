using ReservaVuelo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReservaVuelo.Repositories
{
    public class PagoRepository
    {
        public void RegistrarPago(int reservaId, decimal monto)
        {
            string query = "INSERT INTO Pagos (ReservaID, Monto) VALUES (@reservaId, @monto)";
            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@reservaId", reservaId);
                cmd.Parameters.AddWithValue("@monto", monto);
                cmd.ExecuteNonQuery();
            }
            Database.Instance.Close();
        }

        public List<Pago> ObtenerPagosPorReserva(int reservaId)
        {
            var lista = new List<Pago>();
            string query = "SELECT * FROM Pagos WHERE ReservaID = @id";

            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@id", reservaId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Pago
                        {
                            PagoID = (int)reader["PagoID"],
                            ReservaID = (int)reader["ReservaID"],
                            Monto = (decimal)reader["Monto"],
                            FechaPago = Convert.ToDateTime(reader["FechaPago"])
                        });
                    }
                }
            }
            Database.Instance.Close();
            return lista;
        }
    }
}
