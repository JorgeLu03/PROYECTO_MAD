using PROYECTO_MAD.MODELOS;
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
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            Modelo_Empresa empresa = new Modelo_Empresa();

            TB_RFC.Text = empresa.RFC;
            TB_RAZSOC.Text = empresa.RAZSOC;
            TB_DOMFISC.Text = empresa.DOMFISC;
            TB_NUMCONT.Text = empresa.CONTACT;
            TB_REGPAT.Text = empresa.REGPAT.ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Empresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }
    }
}
