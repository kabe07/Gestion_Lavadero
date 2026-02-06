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
    public partial class VentanaVehiculo : Form
    {
        public VentanaVehiculo()
        {
            InitializeComponent();
        }

        private void VentanaVehiculo_Load(object sender, EventArgs e)
        {
            cbtipo.DataSource = Enum.GetValues(typeof(TipoVehiculo));
        }

        private void cbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
