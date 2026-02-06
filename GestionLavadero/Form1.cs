using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionLavadero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SistemaLavadero sistema = new SistemaLavadero();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sistema.InicializarServicios();
            List<Servicio> ser = sistema.ObtenerServicios();
            cbservicio.DataSource = ser;
            List<Cliente> clientes = sistema.ObtenerClientes();
            cbclientes.DataSource = clientes;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaCliente ventana2 = new VentanaCliente();
            if(ventana2.ShowDialog()==DialogResult.OK)
            {
                string nombre = ventana2.tbnombre.Text;
                int dni = Convert.ToInt32(ventana2.tbdni.Text);
                sistema.CrearClientes(nombre, dni);
                cbclientes.DataSource = null;
                List<Cliente> clientes = sistema.ObtenerClientes();
                cbclientes.DataSource = clientes;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaVehiculo ventana3 = new VentanaVehiculo();
            List<Cliente> clientes = sistema.ObtenerClientes();
            ventana3.cbcliente.DataSource = clientes;
            if (ventana3.ShowDialog()==DialogResult.OK)
            {
                Cliente clienteseleccionado = ventana3.cbcliente.SelectedItem as Cliente;

                
            }
        }
    }
}
