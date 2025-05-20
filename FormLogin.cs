using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//ajuste
namespace ReservaVuelo
{
    using ReservaVuelo;
    public partial class FormLogin : Form
    {
    


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                lblMensaje.Text = "Ingrese usuario y clave.";
                return;
            }

            try
            {
                Database.Instance.Open();

                string query = "SELECT Rol FROM Usuarios WHERE NombreUsuario = @usuario AND Clave = @clave";
                SqlCommand cmd = new SqlCommand(query, Database.Instance.Connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);

                var rol = cmd.ExecuteScalar() as string;

                if (rol != null)
                {
                    MessageBox.Show($"Bienvenido {usuario} - Rol: {rol}");

                    if (rol == "Administrador")
                    {
                        new FormAdministrador().Show();
                    }
                    else if (rol == "Usuario")
                    {
                        string queryPasajero = "SELECT PasajeroID FROM Pasajeros WHERE Nombre = @nombre";
                        SqlCommand cmd2 = new SqlCommand(queryPasajero, Database.Instance.Connection);
                        cmd2.Parameters.AddWithValue("@nombre", usuario);

                        int pasajeroId = (int)(cmd2.ExecuteScalar() ?? 0);
                        new FormUsuario(pasajeroId).Show();
                    }

                    this.Hide();
                }
                else
                {
                    lblMensaje.Text = "Credenciales inválidas.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Database.Instance.Close();
            }
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Instance.Open();
                MessageBox.Show("✅ Conexión exitosa a SQL Server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }
            finally
            {
                Database.Instance.Close();
            }
        }
    }
}
