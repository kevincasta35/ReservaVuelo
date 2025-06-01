using ReservaVuelo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReservaVuelo
{
    public partial class FormPagos : Form
    {
        private string connectionString = "Server=DESKTOP-2US5BA3;Database=ReservaPasajes;Trusted_Connection=True;";

        public FormPagos()
        {
            InitializeComponent();
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            CargarReservas();
            CargarPagos();
        }

        private void CargarReservas()
        {
            cmbReservas.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ReservaID, NumeroVuelo FROM Reservas";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string numero = reader.GetString(1);
                        cmbReservas.Items.Add(new KeyValuePair<int, string>(id, numero));
                    }
                }
            }

            cmbReservas.DisplayMember = "Value";
            cmbReservas.ValueMember = "Key";
        }

        private void CargarPagos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PagoID, ReservaID, Monto, FechaPago FROM Pagos";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgvPagos.DataSource = tabla;
                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cmbReservas.SelectedItem is KeyValuePair<int, string> reservaSeleccionada &&
                decimal.TryParse(txtMonto.Text.Trim(), out decimal monto))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insert = "INSERT INTO Pagos (ReservaID, Monto, FechaPago) VALUES (@reservaId, @monto, @fecha)";
                    using (SqlCommand cmd = new SqlCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@reservaId", reservaSeleccionada.Key);
                        cmd.Parameters.AddWithValue("@monto", monto);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Pago registrado correctamente.");
                CargarPagos();
                txtMonto.Clear();
            }
            else
            {
                MessageBox.Show("Seleccione una reserva y digite un monto válido.");
            }
        }
    }
}
