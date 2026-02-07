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
    public partial class VentanaCliente : Form
    {
        public VentanaCliente()
        {
            InitializeComponent();
        }

        private void VentanaCliente_Load(object sender, EventArgs e)
        {

        }

        private void tbdni_TextChanged(object sender, EventArgs e)
        {
           
        }
        public int Dni { get; set; }
        private void btagregar_Click(object sender, EventArgs e)
        {
            bool vof = int.TryParse(tbdni.Text, out int dni);
            if (!vof || dni < 1000000 || dni > 99000000)
            {
                MessageBox.Show("Ingrese un numero valido porfavor");
                return;
            }
            Dni = dni;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
