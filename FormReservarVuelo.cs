using ReservaVuelo.Models;
using ReservaVuelo.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReservaVuelo
{
    public partial class FormReservarVuelo : Form
    {
        private int pasajeroId;
        private VueloRepository vueloRepo = new VueloRepository();
        private ReservaRepository reservaRepo = new ReservaRepository();

        public FormReservarVuelo(int idPasajero)
        {
            InitializeComponent();
            pasajeroId = idPasajero;
        }

        private void FormReservarVuelo_Load(object sender, EventArgs e)
        {
            CargarVuelosDisponibles();
            txtAsientoAsignado.ReadOnly = true;
        }

        private void CargarVuelosDisponibles()
        {
            var vuelos = vueloRepo.ObtenerVuelosDisponibles();
            cmbVuelosDisponibles.DataSource = vuelos;
            cmbVuelosDisponibles.DisplayMember = "NumeroVuelo";
            cmbVuelosDisponibles.ValueMember = "VueloID";
        }

        private void cmbVuelosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Generar asiento simulado
            Random rnd = new Random();
            txtAsientoAsignado.Text = "A" + rnd.Next(1, 200);
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (cmbVuelosDisponibles.SelectedItem is Vuelo vuelo)
            {
                ReservaDetalle reserva = new ReservaDetalle
                {
                    NumeroVuelo = vuelo.NumeroVuelo,
                    AsientoAsignado = txtAsientoAsignado.Text,
                    EstadoReserva = "Confirmada",
                    FechaReserva = DateTime.Now
                };

                reservaRepo.CrearReserva(pasajeroId, reserva);

                lblEstado.Text = "Reserva registrada exitosamente.";
                CargarVuelosDisponibles(); // refrescar
            }
            else
            {
                lblEstado.Text = "Seleccione un vuelo válido.";
            }
        }
    }
}
