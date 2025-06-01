using ReservaVuelo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaVuelo.Repositories
{

    //Repositorio de pasajeros para la logica de pasajeros
    public class PasajeroRepository
    {
        public List<Pasajero> ObtenerTodos()
        {
            var lista = new List<Pasajero>();
            string query = "SELECT * FROM Pasajeros";

            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Pasajero
                    {
                        PasajeroID = (int)reader["PasajeroID"],
                        Nombre = reader["Nombre"].ToString(),
                        DocumentoIdentidad = reader["DocumentoIdentidad"].ToString(),
                        Email = reader["Email"].ToString(),
                        Telefono = reader["Telefono"].ToString()
                    });
                }
            }
            Database.Instance.Close();
            return lista;
        }

        public void Agregar(Pasajero p)
        {
            string query = "INSERT INTO Pasajeros (Nombre, DocumentoIdentidad, Email, Telefono) VALUES (@n, @d, @e, @t)";
            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@n", p.Nombre);
                cmd.Parameters.AddWithValue("@d", p.DocumentoIdentidad);
                cmd.Parameters.AddWithValue("@e", p.Email);
                cmd.Parameters.AddWithValue("@t", p.Telefono);
                cmd.ExecuteNonQuery();
            }
            Database.Instance.Close();
        }
        
        public void Actualizar(Pasajero p)
        {
            string query = "UPDATE Pasajeros SET Nombre=@n, DocumentoIdentidad=@d, Email=@e, Telefono=@t WHERE PasajeroID=@id";
            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@n", p.Nombre);
                cmd.Parameters.AddWithValue("@d", p.DocumentoIdentidad);
                cmd.Parameters.AddWithValue("@e", p.Email);
                cmd.Parameters.AddWithValue("@t", p.Telefono);
                cmd.Parameters.AddWithValue("@id", p.PasajeroID);
                cmd.ExecuteNonQuery();
            }
            Database.Instance.Close();
        }

        public void Eliminar(int id)
        {
            string query = "DELETE FROM Pasajeros WHERE PasajeroID = @id";
            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            Database.Instance.Close();
        }
        public Pasajero ObtenerPorNombre(string nombre)
        {
            Pasajero pasajero = null;
            string query = "SELECT * FROM Pasajeros WHERE Nombre = @nombre";
            Database.Instance.Open();
            using (SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pasajero = new Pasajero
                        {
                            PasajeroID = (int)reader["PasajeroID"],
                            Nombre = reader["Nombre"].ToString(),
                            DocumentoIdentidad = reader["DocumentoIdentidad"].ToString(),
                            Email = reader["Email"].ToString(),
                            Telefono = reader["Telefono"].ToString()
                        };
                    }
                }
            }
            Database.Instance.Close();
            return pasajero;
        }
    }
}
