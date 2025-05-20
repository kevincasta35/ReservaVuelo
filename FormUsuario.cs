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

    //Form usuario normal
    public partial class FormUsuario : Form
    {
        private int pasajeroId;
        ReservaRepository repo = new ReservaRepository();

        public FormUsuario(int id)
        {
            InitializeComponent();
            pasajeroId = id;
            cmbFiltro.Items.Add("Futuras");
            cmbFiltro.Items.Add("Anteriores");
            cmbFiltro.SelectedIndex = 0;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFiltro.Items.Add("Futuras");
            cmbFiltro.Items.Add("Anteriores");
            cmbFiltro.SelectedIndex = 0;
        }

        private void btnCargarReservas_Click(object sender, EventArgs e)
        {
            bool futuras = cmbFiltro.SelectedItem.ToString() == "Futuras";
            dgvReservas.DataSource = repo.ObtenerReservasPorPasajero(pasajeroId, futuras);
        }
    }
}
