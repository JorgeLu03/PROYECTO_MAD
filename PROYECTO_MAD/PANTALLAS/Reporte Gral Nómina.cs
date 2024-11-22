using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAD.PANTALLAS
{
    public partial class Reporte_Gral_Nómina : Form
    {
        public Reporte_Gral_Nómina()
        {
            InitializeComponent();
        }

        private void Reporte_Gral_Nómina_Load(object sender, EventArgs e)
        {

        }

        private void Reporte_Gral_Nómina_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }
    }
}
