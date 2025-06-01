namespace ReservaVuelo
{
    partial class FormReservarVuelo
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
            this.cmbVuelosDisponibles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsientoAsignado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbVuelosDisponibles
            // 
            this.cmbVuelosDisponibles.FormattingEnabled = true;
            this.cmbVuelosDisponibles.Location = new System.Drawing.Point(160, 40);
            this.cmbVuelosDisponibles.Name = "cmbVuelosDisponibles";
            this.cmbVuelosDisponibles.Size = new System.Drawing.Size(200, 21);
            this.cmbVuelosDisponibles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar vuelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asiento asignado:";
            // 
            // txtAsientoAsignado
            // 
            this.txtAsientoAsignado.Location = new System.Drawing.Point(160, 77);
            this.txtAsientoAsignado.Name = "txtAsientoAsignado";
            this.txtAsientoAsignado.Size = new System.Drawing.Size(200, 20);
            this.txtAsientoAsignado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio del vuelo:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(160, 117);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(160, 160);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(100, 30);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(274, 169);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(78, 13);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado reserva";
            // 
            // FormReservarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 220);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAsientoAsignado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVuelosDisponibles);
            this.Name = "FormReservarVuelo";
            this.Text = "Reservar Vuelo";
            this.Load += new System.EventHandler(this.FormReservarVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVuelosDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsientoAsignado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label lblEstado;
    }
}
