using System;

namespace ReservaVuelo
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnCargarReservas = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de Reservas";
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(199, 53);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(240, 150);
            this.dgvReservas.TabIndex = 1;
            // 
            // btnCargarReservas
            // 
            this.btnCargarReservas.Location = new System.Drawing.Point(73, 251);
            this.btnCargarReservas.Name = "btnCargarReservas";
            this.btnCargarReservas.Size = new System.Drawing.Size(103, 23);
            this.btnCargarReservas.TabIndex = 2;
            this.btnCargarReservas.Text = "Mostrar reservas";
            this.btnCargarReservas.UseVisualStyleBackColor = true;
            this.btnCargarReservas.Click += new System.EventHandler(this.btnCargarReservas_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(55, 164);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 3;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtro";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(227, 251);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(128, 23);
            this.btnCancelarReserva.TabIndex = 5;
            this.btnCancelarReserva.Text = "Cancelar Reservas";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnCargarReservas);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.label1);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí va la lógica para filtrar las reservas
            // Puedes llamar al método que carga las reservas dependiendo del filtro (futuras o pasadas)
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnCargarReservas;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarReserva;
    }
}