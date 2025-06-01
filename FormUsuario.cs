using ReservaVuelo.Models;
using ReservaVuelo.Repositories;
using System;
using System.Windows.Forms;

namespace ReservaVuelo
{
    public partial class FormUsuario : Form
    {
        private int pasajeroId;
        private ReservaRepository repo = new ReservaRepository();

        public FormUsuario(int id)
        {
            InitializeComponent();
            pasajeroId = id;
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            // Inicializar ComboBox una sola vez al cargar el formulario
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("Todas");
            cmbFiltro.Items.Add("Futuras");
            cmbFiltro.Items.Add("Pasadas");
            cmbFiltro.SelectedIndex = 0;

            CargarReservas();
        }

        private void btnCargarReservas_Click(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void CargarReservas()
        {
            if (cmbFiltro.SelectedItem == null) return;

            string filtro = cmbFiltro.SelectedItem.ToString();

            if (filtro == "Todas")
            {
                dgvReservas.DataSource = repo.ObtenerReservasPorPasajero(pasajeroId, true); // null = sin filtro
            }
            else if (filtro == "Futuras")
            {
                dgvReservas.DataSource = repo.ObtenerReservasPorPasajero(pasajeroId, true);
            }
            else // "Pasadas"
            {
                dgvReservas.DataSource = repo.ObtenerReservasPorPasajero(pasajeroId, false);
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                var reserva = dgvReservas.CurrentRow.DataBoundItem as ReservaDetalle;

                if (reserva != null && reserva.FechaSalida > DateTime.Now)
                {
                    DialogResult result = MessageBox.Show(
                        "¿Estás seguro de que deseas cancelar esta reserva?",
                        "Confirmar cancelación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        repo.CancelarReserva(reserva.ReservaID);
                        MessageBox.Show("Reserva cancelada correctamente.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarReservas();
                    }
                }
                else
                {
                    MessageBox.Show("Solo puedes cancelar reservas futuras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una reserva para cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
