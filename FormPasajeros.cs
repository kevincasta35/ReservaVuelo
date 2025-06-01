using ReservaVuelo.Models;
using ReservaVuelo.Repositories;
using System;
using System.Windows.Forms;

namespace ReservaVuelo


    //Crear formulario para pasajeros FormPasajeros
    public partial class FormPasajeros : Form
    {
        private PasajeroRepository pasajeroRepo = new PasajeroRepository();

        public FormPasajeros()
        {
            InitializeComponent();
            CargarPasajeros();
        }

        private void CargarPasajeros()
        {
            dgvPasajeros.DataSource = null;
            dgvPasajeros.DataSource = pasajeroRepo.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var pasajero = new Pasajero
            {
                Nombre = txtNombre.Text,
                DocumentoIdentidad = txtDocumento.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text
            };

            pasajeroRepo.Agregar(pasajero);
            MessageBox.Show("Pasajero agregado exitosamente.");
            CargarPasajeros();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvPasajeros.CurrentRow != null)
            {
                var pasajero = (Pasajero)dgvPasajeros.CurrentRow.DataBoundItem;

                pasajero.Nombre = txtNombre.Text;
                pasajero.DocumentoIdentidad = txtDocumento.Text;
                pasajero.Email = txtEmail.Text;
                pasajero.Telefono = txtTelefono.Text;

                pasajeroRepo.Actualizar(pasajero);
                MessageBox.Show("Pasajero actualizado.");
                CargarPasajeros();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPasajeros.CurrentRow != null)
            {
                var pasajero = (Pasajero)dgvPasajeros.CurrentRow.DataBoundItem;
                pasajeroRepo.Eliminar(pasajero.PasajeroID);
                MessageBox.Show("Pasajero eliminado.");
                CargarPasajeros();
            }
        }

        private void dgvPasajeros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPasajeros.CurrentRow != null)
            {
                var pasajero = (Pasajero)dgvPasajeros.CurrentRow.DataBoundItem;
                txtNombre.Text = pasajero.Nombre;
                txtDocumento.Text = pasajero.DocumentoIdentidad;
                txtEmail.Text = pasajero.Email;
                txtTelefono.Text = pasajero.Telefono;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPasajeros_Load(object sender, EventArgs e)
        {

        }
    }
}
