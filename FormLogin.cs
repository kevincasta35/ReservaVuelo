using System;
using System.Windows.Forms;
using ReservaVuelo.Repositories;
using ReservaVuelo.Models;

namespace ReservaVuelo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = ""; // Limpia el mensaje al cargar
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(clave))
            {
                lblMensaje.Text = "Ingrese usuario y clave.";
                return;
            }

            try
            {
                var usuarioRepo = new UsuarioRepository();
                Usuario usuario = usuarioRepo.ObtenerPorNombreYClave(nombreUsuario, clave);

                if (usuario != null && usuario.Rol == "Administrador")
                {
                    new FormAdministrador().Show();
                    this.Hide();
                }
                else if (usuario != null && usuario.Rol == "Usuario")
                {
                    var pasajeroRepo = new PasajeroRepository();
                    var pasajero = pasajeroRepo.ObtenerPorNombre(usuario.NombreUsuario);

                    if (pasajero != null)
                    {
                        new FormUsuario(pasajero.PasajeroID).Show();
                        this.Hide();
                    }
                    else
                    {
                        lblMensaje.Text = "El usuario no tiene un pasajero asociado.";
                    }
                }
                else
                {
                    lblMensaje.Text = "Credenciales inválidas.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = ""; // Limpia mensaje al cambiar texto
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Instance.Open();
                MessageBox.Show("Conexión exitosa a la base de datos.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.Instance.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
