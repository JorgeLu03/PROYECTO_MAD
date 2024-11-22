using PROYECTO_MAD.DAO;
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
    public partial class STRIPMENU : Form
    {
        public STRIPMENU()
        {
            InitializeComponent();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallasDAO.pantallaEmpresa.ShowDialog();


        }

        private void STRIPMENU_Load(object sender, EventArgs e)
        {

        }
    }
}
