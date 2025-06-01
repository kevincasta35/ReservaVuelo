namespace ReservaVuelo
{
    partial class FormPagos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbReservas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dgvPagos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbReservas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            this.label1.Text = "Selecciona una reserva:";
            this.label1.Location = new System.Drawing.Point(30, 20);
            // 
            // cmbReservas
            this.cmbReservas.Location = new System.Drawing.Point(30, 45);
            this.cmbReservas.Size = new System.Drawing.Size(200, 21);
            // 
            // label2
            this.label2.Text = "Monto a pagar:";
            this.label2.Location = new System.Drawing.Point(30, 80);
            // 
            // txtMonto
            this.txtMonto.Location = new System.Drawing.Point(30, 100);
            this.txtMonto.Size = new System.Drawing.Size(200, 20);
            // 
            // btnPagar
            this.btnPagar.Text = "Registrar Pago";
            this.btnPagar.Location = new System.Drawing.Point(30, 130);
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // dgvPagos
            this.dgvPagos.Location = new System.Drawing.Point(270, 20);
            this.dgvPagos.Size = new System.Drawing.Size(500, 200);
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // FormPagos
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbReservas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dgvPagos);
            this.Text = "Registro de Pagos";
            this.Load += new System.EventHandler(this.FormPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
