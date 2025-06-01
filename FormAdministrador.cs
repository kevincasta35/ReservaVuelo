using ReservaVuelo.Models;
using ReservaVuelo.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ReservaVuelo
{
    public partial class FormAdministrador : Form
    {
        private VueloRepository vueloRepository = new VueloRepository();

        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            btnCargar.PerformClick(); // Carga automática
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dgvVuelos.DataSource = null;
            dgvVuelos.DataSource = vueloRepository.ObtenerVuelos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
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

                vueloRepository.AgregarVuelo(vuelo);
                MessageBox.Show("Vuelo agregado correctamente", "Éxito");
                btnCargar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar vuelo: " + ex.Message, "Error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numeroVuelo = txtNumeroVuelo.Text;
            var vuelo = vueloRepository.ObtenerVueloPorNumero(numeroVuelo);

            if (vuelo != null)
            {
                txtOrigen.Text = vuelo.Origen;
                txtDestino.Text = vuelo.Destino;
                dtpFechaSalida.Value = vuelo.FechaSalida;
                dtpHoraSalida.Value = DateTime.Today.Add(vuelo.HoraSalida);
                dtpHoraLlegada.Value = DateTime.Today.Add(vuelo.HoraLlegada);
                txtCapacidad.Text = vuelo.Capacidad.ToString();
                txtEstado.Text = vuelo.Estado;

                dgvVuelos.DataSource = null;
                dgvVuelos.DataSource = new[] { vuelo }; // Mostrar solo el vuelo buscado
            }
            else
            {
                MessageBox.Show("Vuelo no encontrado", "Información");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var vuelo = vueloRepository.ObtenerVueloPorNumero(txtNumeroVuelo.Text);
                if (vuelo == null)
                {
                    MessageBox.Show("No se encontró el vuelo para actualizar.", "Error");
                    return;
                }

                vuelo.Origen = txtOrigen.Text;
                vuelo.Destino = txtDestino.Text;
                vuelo.FechaSalida = dtpFechaSalida.Value;
                vuelo.HoraSalida = dtpHoraSalida.Value.TimeOfDay;
                vuelo.HoraLlegada = dtpHoraLlegada.Value.TimeOfDay;
                vuelo.Capacidad = int.Parse(txtCapacidad.Text);
                vuelo.Estado = txtEstado.Text;

                vueloRepository.ActualizarVuelo(vuelo);
                MessageBox.Show("Vuelo actualizado correctamente", "Éxito");
                btnCargar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var vuelo = vueloRepository.ObtenerVueloPorNumero(txtNumeroVuelo.Text);
                if (vuelo == null)
                {
                    MessageBox.Show("No se encontró el vuelo para eliminar.", "Error");
                    return;
                }

                var confirm = MessageBox.Show("¿Estás seguro de eliminar este vuelo?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    vueloRepository.EliminarVuelo(vuelo.VueloID);
                    MessageBox.Show("Vuelo eliminado", "Éxito");
                    btnCargar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string numeroVuelo = txtNumeroVuelo.Text.Trim();

            if (!string.IsNullOrEmpty(numeroVuelo))
            {
                var vuelos = vueloRepository.ObtenerVuelos()
                    .Where(v => v.NumeroVuelo.Equals(numeroVuelo, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (vuelos.Any())
                {
                    dgvVuelos.DataSource = null;
                    dgvVuelos.DataSource = vuelos;
                }
                else
                {
                    MessageBox.Show("No se encontró ningún vuelo con ese número.", "Búsqueda sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número de vuelo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
