namespace Parqueadero
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFecha_entrada = new System.Windows.Forms.DateTimePicker();
            this.cbTipo_vehiculo = new System.Windows.Forms.ComboBox();
            this.txtNombre_cliente = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero_horas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValor_total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtFecha_salida = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº identificación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo vehiculo:";
            // 
            // dtFecha_entrada
            // 
            this.dtFecha_entrada.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtFecha_entrada.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtFecha_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha_entrada.Location = new System.Drawing.Point(138, 13);
            this.dtFecha_entrada.Name = "dtFecha_entrada";
            this.dtFecha_entrada.Size = new System.Drawing.Size(200, 20);
            this.dtFecha_entrada.TabIndex = 5;
            // 
            // cbTipo_vehiculo
            // 
            this.cbTipo_vehiculo.FormattingEnabled = true;
            this.cbTipo_vehiculo.Location = new System.Drawing.Point(138, 43);
            this.cbTipo_vehiculo.Name = "cbTipo_vehiculo";
            this.cbTipo_vehiculo.Size = new System.Drawing.Size(200, 21);
            this.cbTipo_vehiculo.TabIndex = 6;
            // 
            // txtNombre_cliente
            // 
            this.txtNombre_cliente.Location = new System.Drawing.Point(138, 73);
            this.txtNombre_cliente.Name = "txtNombre_cliente";
            this.txtNombre_cliente.Size = new System.Drawing.Size(200, 20);
            this.txtNombre_cliente.TabIndex = 7;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(138, 107);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(200, 20);
            this.txtIdentificacion.TabIndex = 8;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(138, 140);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(200, 20);
            this.txtPlaca.TabIndex = 9;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(263, 202);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 23);
            this.btnFacturar.TabIndex = 10;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha salida:";
            // 
            // txtNumero_horas
            // 
            this.txtNumero_horas.Location = new System.Drawing.Point(138, 234);
            this.txtNumero_horas.Name = "txtNumero_horas";
            this.txtNumero_horas.Size = new System.Drawing.Size(200, 20);
            this.txtNumero_horas.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número horas:";
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(138, 266);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(200, 20);
            this.txtTarifa.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tarifa:";
            // 
            // txtValor_total
            // 
            this.txtValor_total.Location = new System.Drawing.Point(138, 297);
            this.txtValor_total.Name = "txtValor_total";
            this.txtValor_total.Size = new System.Drawing.Size(200, 20);
            this.txtValor_total.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Valor total:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(263, 327);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtFecha_salida
            // 
            this.dtFecha_salida.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtFecha_salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha_salida.Location = new System.Drawing.Point(138, 172);
            this.dtFecha_salida.Name = "dtFecha_salida";
            this.dtFecha_salida.Size = new System.Drawing.Size(200, 20);
            this.dtFecha_salida.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 362);
            this.Controls.Add(this.dtFecha_salida);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtValor_total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumero_horas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNombre_cliente);
            this.Controls.Add(this.cbTipo_vehiculo);
            this.Controls.Add(this.dtFecha_entrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Parqueadero";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFecha_entrada;
        private System.Windows.Forms.ComboBox cbTipo_vehiculo;
        private System.Windows.Forms.TextBox txtNombre_cliente;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero_horas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValor_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtFecha_salida;
    }
}

