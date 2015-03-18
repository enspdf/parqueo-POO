using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Parqueadero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtNumero_horas.Enabled = false;
            txtTarifa.Enabled = false;
            txtValor_total.Enabled = false;
            cbTipo_vehiculo.Items.Add("Moto");
            cbTipo_vehiculo.Items.Add("Carro");
            btnGuardar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Prq cl = new Prq();
            //txtTarifa.Text = cl.TarifaVehiculo.ToString();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            ClPrq objetovehiculo = new ClPrq();
            objetovehiculo.TipoVehiculo = cbTipo_vehiculo.Text;
            int Tarifa = objetovehiculo.TarifaVehiculo;
            TimeSpan PeriodoPagar = dtFecha_salida.Value - dtFecha_entrada.Value;
            Double NroHoras = PeriodoPagar.TotalHours;
            Double ValorTotal = NroHoras * Tarifa;
            txtNumero_horas.Text = NroHoras.ToString();
            txtTarifa.Text = Tarifa.ToString();
            txtValor_total.Text = ValorTotal.ToString();
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("factura.txt");
            escribir.Write("Fecha de entrada: " + dtFecha_entrada.Value);
            escribir.Write(System.Environment.NewLine + "Tipo de vehiculo: " + cbTipo_vehiculo.SelectedText);
            escribir.Write(System.Environment.NewLine + "Nombre: " + txtNombre_cliente.Text);
            escribir.Write(System.Environment.NewLine + "Indetificación: " + txtIdentificacion.Text);
            escribir.Write(System.Environment.NewLine + "Placa: " + txtPlaca.Text);
            escribir.Write(System.Environment.NewLine + "Fecha salida: " + dtFecha_salida.Text);
            escribir.Write(System.Environment.NewLine + "Numero de horas: " + txtNumero_horas.Text);
            escribir.Write(System.Environment.NewLine + "Tarifa: " + txtTarifa.Text);
            escribir.Write(System.Environment.NewLine + "Total a pagar: " + txtValor_total.Text);
            escribir.Close();

            //Process.Start("notepad.exe", "factura.txt");
            Process notepad = Process.Start("notepad.exe", "factura.txt");
            this.Close();
        }
    }
}
