using PROYECTO_MAD.DAO;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void AGREGAR_Click(object sender, EventArgs e)
        {
            Modelo_Empleados empleados = new Modelo_Empleados(0,TB_NOM.Text, DTP_FECHNAC.Value, TB_CURP.Text,TB_EMAIL.Text);
            EmpleadoDAO.sp_gestion_empleado(empleados,"AGREGAR");
        }

        private void MODIFY_Click(object sender, EventArgs e)
        {
            Modelo_Empleados empleados = new Modelo_Empleados(0, TB_NOM.Text, DTP_FECHNAC.Value, TB_CURP.Text, TB_EMAIL.Text);
            EmpleadoDAO.sp_gestion_empleado(empleados, "MODIFICAR");
        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {
            Modelo_Empleados empleados = new Modelo_Empleados(0, TB_NOM.Text, DTP_FECHNAC.Value, TB_CURP.Text, TB_EMAIL.Text);
            EmpleadoDAO.sp_gestion_empleado(empleados, "ELIMINAR");
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            List<Modelo_Empleados> data = EmpleadoDAO.sp_get_empleado("");
            DG_1.DataSource = data;
        }

        private void TB_BUSCAR_TextChanged(object sender, EventArgs e)
        {
            string buscar=TB_BUSCAR.Text;
            List<Modelo_Empleados> data = EmpleadoDAO.sp_get_empleado(buscar);
            DG_1.DataSource = data;
        }

        private void nóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }
    }
}
