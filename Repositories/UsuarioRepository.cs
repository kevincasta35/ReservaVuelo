using ReservaVuelo.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaVuelo.Repositories
{
    public class UsuarioRepository
    {
        private string connectionString = "Server=DESKTOP-2US5BA3;Database=ReservaPasajes;Trusted_Connection=True;";

        public Usuario ObtenerPorNombreYClave(string nombreUsuario, string clave)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Usuarios WHERE NombreUsuario = @nombre AND Clave = @clave", connection);
                command.Parameters.AddWithValue("@nombre", nombreUsuario.Trim());
                command.Parameters.AddWithValue("@clave", clave.Trim());

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Usuario encontrado"); // ✅ Confirmación
                        return new Usuario
                        {
                            UsuarioID = Convert.ToInt32(reader["UsuarioID"]),
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            Clave = reader["Clave"].ToString(),
                            Rol = reader["Rol"].ToString()
                        };
                    }
                    else
                    {
                        MessageBox.Show("❌ No se encontró usuario con esas credenciales");
                    }
                }
            }
            return null;
        }
    }
}
