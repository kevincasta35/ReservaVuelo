namespace ReservaVuelo
{
    partial class FormAdministrador
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
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.txtNumeroVuelo = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.vuelo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.destino = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelos.Location = new System.Drawing.Point(333, 20);
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.Size = new System.Drawing.Size(240, 150);
            this.dgvVuelos.TabIndex = 0;
            // 
            // txtNumeroVuelo
            // 
            this.txtNumeroVuelo.Location = new System.Drawing.Point(103, 51);
            this.txtNumeroVuelo.Name = "txtNumeroVuelo";
            this.txtNumeroVuelo.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroVuelo.TabIndex = 1;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(102, 84);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtOrigen.TabIndex = 2;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(102, 123);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 3;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(95, 154);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidad.TabIndex = 4;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(77, 185);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 5;
            // 
            // vuelo
            // 
            this.vuelo.AutoSize = true;
            this.vuelo.Location = new System.Drawing.Point(24, 51);
            this.vuelo.Name = "vuelo";
            this.vuelo.Size = new System.Drawing.Size(73, 13);
            this.vuelo.TabIndex = 6;
            this.vuelo.Text = "Numero vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Origen";
            // 
            // destino
            // 
            this.destino.AutoSize = true;
            this.destino.Location = new System.Drawing.Point(39, 123);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(43, 13);
            this.destino.TabIndex = 8;
            this.destino.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Capacidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(42, 242);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSalida.TabIndex = 11;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Location = new System.Drawing.Point(42, 291);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraSalida.TabIndex = 12;
            // 
            // dtpHoraLlegada
            // 
            this.dtpHoraLlegada.Location = new System.Drawing.Point(42, 344);
            this.dtpHoraLlegada.Name = "dtpHoraLlegada";
            this.dtpHoraLlegada.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraLlegada.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hora salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hora llegada";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(363, 221);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(498, 221);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(363, 301);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(498, 301);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 20;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(266, 221);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHoraLlegada);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vuelo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtNumeroVuelo);
            this.Controls.Add(this.dgvVuelos);
            this.Name = "FormAdministrador";
            this.Text = "FormAdministrador";
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.TextBox txtNumeroVuelo;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label vuelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label destino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraLlegada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBuscar;
    }
}