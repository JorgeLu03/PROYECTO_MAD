using PROYECTO_MAD.Entidad;
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
    public partial class Principal_Todos : Form
    {
        public Principal_Todos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal pantallaGestorEmpleados = new Principal();
            pantallaGestorEmpleados.ShowDialog();
        }

        private void BTN_EMP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleado pantallaEmpleado = new Empleado();
            pantallaEmpleado.ShowDialog();
        }

        private void BTN_GESDEP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Departamentos pantallaDepartamentos = new Departamentos();
            pantallaDepartamentos.ShowDialog();
        }

        private void BTN_GESEMPR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empresa pantallaGestorEmpresa = new Empresa();
            pantallaGestorEmpresa.ShowDialog();
        }

        private void BTN_PERC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Percepciones_y_deducciones pantallaPercyDed = new Percepciones_y_deducciones();
            pantallaPercyDed.ShowDialog();
        }

        private void BTN_PUES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte_Puesto_y_dpt pantallaReportePuestosyDep = new Reporte_Puesto_y_dpt();
            pantallaReportePuestosyDep.ShowDialog();
        }

        private void BTN_GESPUES_Click(object sender, EventArgs e)
        {
            this.Hide();
            Puestos pantallaRepPues = new Puestos();
            pantallaRepPues.ShowDialog();
        }

        private void BTN_NOMGEN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte_Gral_Nómina pantallaRepGralNomina = new Reporte_Gral_Nómina();
            pantallaRepGralNomina.ShowDialog();
        }

        private void BTN_NOM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reporte_nómina pantallaRepNom = new Reporte_nómina();
            pantallaRepNom.ShowDialog();
        }

        private void Principal_Todos_Load(object sender, EventArgs e)
        {
            if (Sesion.empleado.id_puesto != 1002)
            {
                BTN_EMP.Enabled = false;
            }
            else
            {
                BTN_GESDEP.Enabled = false;
                BTN_GESEMPL.Enabled = false;
                BTN_GESEMPR.Enabled = false;
                BTN_GESPUES.Enabled = false;
                BTN_NOM.Enabled = false;
                BTN_NOMGEN.Enabled = false;
                BTN_PERC.Enabled = false;
                BTN_PUES.Enabled = false;

            }
            string nombreCompleto = $"{Sesion.empleado.nombre} {Sesion.empleado.apellido_paterno} {Sesion.empleado.apellido_materno}";
            LB_NOMBRE.Text = nombreCompleto;
            string PuestoLabel = Convert.ToString(Sesion.empleado.id_puesto);

            LB_PUESTO.Text = PuestoLabel;
        }

        private void BTN_LOGOUT_Click(object sender, EventArgs e)
        {
            Sesion.empleado = null;
            this.Hide();
            Login pantallaLogin = new Login();
            pantallaLogin.ShowDialog();

        }

        private void LB_NOMBRE_Click(object sender, EventArgs e)
        {

        }
    }
}
