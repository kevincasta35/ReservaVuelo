using ReservaVuelo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ReservaVuelo.Repositories
{
    public class VueloRepository
    {
        public List<Vuelo> ObtenerVuelos()
        {
            var lista = new List<Vuelo>();
            string query = "SELECT * FROM Vuelos";

            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(MapearVuelo(reader));
                }
            }
            Database.Instance.Close();
            return lista;
        }

        public Vuelo ObtenerVueloPorNumero(string numeroVuelo)
        {
            Vuelo vuelo = null;
            string query = "SELECT * FROM Vuelos WHERE NumeroVuelo = @num";

            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@num", numeroVuelo);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vuelo = MapearVuelo(reader);
                    }
                }
            }
            Database.Instance.Close();
            return vuelo;
        }

        public void AgregarVuelo(Vuelo vuelo)
        {
            string query = @"INSERT INTO Vuelos 
            (NumeroVuelo, Origen, Destino, FechaSalida, HoraSalida, HoraLlegada, Capacidad, Estado)
            VALUES (@num, @origen, @destino, @fecha, @horaSal, @horaLle, @cap, @estado)";

            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@num", vuelo.NumeroVuelo);
                cmd.Parameters.AddWithValue("@origen", vuelo.Origen);
                cmd.Parameters.AddWithValue("@destino", vuelo.Destino);
                cmd.Parameters.AddWithValue("@fecha", vuelo.FechaSalida);
                cmd.Parameters.AddWithValue("@horaSal", vuelo.HoraSalida);
                cmd.Parameters.AddWithValue("@horaLle", vuelo.HoraLlegada);
                cmd.Parameters.AddWithValue("@cap", vuelo.Capacidad);
                cmd.Parameters.AddWithValue("@estado", vuelo.Estado);
                cmd.ExecuteNonQuery();
            }
            Database.Instance.Close();
        }

        public void ActualizarVuelo(Vuelo vuelo)
        {
            string query = @"UPDATE Vuelos SET 
            Origen=@origen, Destino=@destino, 
            FechaSalida=@fecha, HoraSalida=@horaSal, HoraLlegada=@horaLle, 
            Capacidad=@cap, Estado=@estado WHERE VueloID=@id";

            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@origen", vuelo.Origen);
                cmd.Parameters.AddWithValue("@destino", vuelo.Destino);
                cmd.Parameters.AddWithValue("@fecha", vuelo.FechaSalida);
                cmd.Parameters.AddWithValue("@horaSal", vuelo.HoraSalida);
                cmd.Parameters.AddWithValue("@horaLle", vuelo.HoraLlegada);
                cmd.Parameters.AddWithValue("@cap", vuelo.Capacidad);
                cmd.Parameters.AddWithValue("@estado", vuelo.Estado);
                cmd.Parameters.AddWithValue("@id", vuelo.VueloID);
                cmd.ExecuteNonQuery();
            }
            Database.Instance.Close();
        }

        public void EliminarVuelo(int id)
        {
            string query = "DELETE FROM Vuelos WHERE VueloID = @id";
            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            Database.Instance.Close();
        }

        private Vuelo MapearVuelo(SqlDataReader reader)
        {
            return new Vuelo
            {
                VueloID = (int)reader["VueloID"],
                NumeroVuelo = reader["NumeroVuelo"].ToString(),
                Origen = reader["Origen"].ToString(),
                Destino = reader["Destino"].ToString(),
                FechaSalida = (DateTime)reader["FechaSalida"],
                HoraSalida = (TimeSpan)reader["HoraSalida"],
                HoraLlegada = (TimeSpan)reader["HoraLlegada"],
                Capacidad = (int)reader["Capacidad"],
                Estado = reader["Estado"].ToString()
            };
        }
////////////NUEVOOOO
        public List<Vuelo> ObtenerVuelosDisponibles()
        {
            var lista = new List<Vuelo>();
            string query = "SELECT * FROM Vuelos WHERE Estado = 'Disponible'";

            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Vuelo
                    {
                        VueloID = (int)reader["VueloID"],
                        NumeroVuelo = reader["NumeroVuelo"].ToString(),
                        Origen = reader["Origen"].ToString(),
                        Destino = reader["Destino"].ToString(),
                        FechaSalida = (DateTime)reader["FechaSalida"],
                        HoraSalida = (TimeSpan)reader["HoraSalida"],
                        HoraLlegada = (TimeSpan)reader["HoraLlegada"],
                        Capacidad = (int)reader["Capacidad"],
                        Estado = reader["Estado"].ToString()
                    });
                }
            }
            Database.Instance.Close();
            return lista;
        }

    }
}
