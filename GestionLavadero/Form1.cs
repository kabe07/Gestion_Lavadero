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

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
