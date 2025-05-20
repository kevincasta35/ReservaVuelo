using ReservaVuelo.Models;
using ReservaVuelo.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaVuelo
{
    //Implementacion formulario administrador

    public partial class FormAdministrador : Form
    {

        VueloRepository repo = new VueloRepository();
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dgvVuelos.DataSource = null;
            dgvVuelos.DataSource = repo.ObtenerVuelos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var vuelo = new Vuelo
            {
                NumeroVuelo = txtNumeroVuelo.Text,
                Origen = txtOrigen.Text,
                Destino = txtDestino.Text,
                FechaSalida = dtpFechaSalida.Value,
                HoraSalida = dtpHoraSalida.Value.TimeOfDay,
                HoraLlegada = dtpHoraLlegada.Value.TimeOfDay,
                Capacidad = int.Parse(txtCapacidad.Text),
                Estado = txtEstado.Text
            };

            repo.AgregarVuelo(vuelo);
            btnCargar.PerformClick();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVuelos.SelectedRows.Count > 0)
            {
                int id = (int)dgvVuelos.SelectedRows[0].Cells["VueloID"].Value;
                repo.EliminarVuelo(id);
                btnCargar.PerformClick();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvVuelos.SelectedRows.Count > 0)
            {
                int id = (int)dgvVuelos.SelectedRows[0].Cells["VueloID"].Value;

                var vuelo = new Vuelo
                {
                    VueloID = id,
                    NumeroVuelo = txtNumeroVuelo.Text,
                    Origen = txtOrigen.Text,
                    Destino = txtDestino.Text,
                    FechaSalida = dtpFechaSalida.Value,
                    HoraSalida = dtpHoraSalida.Value.TimeOfDay,
                    HoraLlegada = dtpHoraLlegada.Value.TimeOfDay,
                    Capacidad = int.Parse(txtCapacidad.Text),
                    Estado = txtEstado.Text
                };

                repo.ActualizarVuelo(vuelo);
                btnCargar.PerformClick();
            }
        }
    }
}
