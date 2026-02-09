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
using System.Runtime.Serialization.Formatters.Binary;

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
            sistema = SistemaLavadero.Cargar("lavadero.dat");    
            List<Servicio> ser = sistema.ObtenerServicios();
            cbservicio.DataSource = null;
            cbservicio.DataSource = ser;
            List<Cliente> clientes = sistema.ObtenerClientes();
            cbclientes.DataSource = null;
            cbclientes.DataSource = clientes;
            lbturnos.DataSource = null;
            lbturnos.DataSource = sistema.ObtenerTurnos();
            lblavados.DataSource = null;
            lblavados.DataSource = sistema.ObtenerTurnosLavados();
            double total = sistema.Facturacion2();
            tb2.Text = total.ToString("0.00");
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = cbclientes.SelectedItem as Cliente;
            if (cliente == null)
            {
                cbvehiculos.DataSource = null;
                return;
            }
            List<Vehiculo> lista=sistema.MostrarListaVehiculos(cliente);
            cbvehiculos.DataSource = null;
            cbvehiculos.DataSource = lista;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaCliente ventana2 = new VentanaCliente();
            if(ventana2.ShowDialog()==DialogResult.OK)
            {
                string nombre = ventana2.tbnombre.Text;
                int dni = ventana2.Dni;
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
                string marca = ventana3.tbmarca.Text;
                string modelo = ventana3.tbmodelo.Text;
                TipoVehiculo tipo = (TipoVehiculo)ventana3.cbtipo.SelectedItem;
                sistema.AgregarV(marca, modelo, tipo,clienteseleccionado);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtp.Value;
            Vehiculo vehiculo = cbvehiculos.SelectedItem as Vehiculo;
            Servicio servicio = cbservicio.SelectedItem as Servicio;
            sistema.CrearTurno(fecha, vehiculo, servicio);
            lbturnos.DataSource = null;
            List<Turno>turnos = sistema.ObtenerTurnos();
            turnos.Sort();
            lbturnos.DataSource = turnos;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Turno turno = lbturnos.SelectedItem as Turno;
            if(turno==null)
            {
                MessageBox.Show("Debe seleccionar un turno");
                return;
            }
            bool ok = double.TryParse(tbfacturacion.Text, out double facturacion);
            if (!ok)
            {
                MessageBox.Show("Ingrese un precio valido");
                return;
            }
            sistema.EliminarTurno(turno);
            sistema.AgregarTurno(turno);
            lbturnos.DataSource = null;
            lbturnos.DataSource = sistema.ObtenerTurnos();
            lblavados.DataSource = null;
            lblavados.DataSource = sistema.ObtenerTurnosLavados();
           
            double total=sistema.Facturacion(facturacion);
            tb2.Text = total.ToString("0.00");
        }
        
        private void btsalir_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SistemaLavadero.Guardar("lavadero.dat", sistema);
        }
    }
}
