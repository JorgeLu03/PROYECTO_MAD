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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROYECTO_MAD.PANTALLAS
{
    public partial class Principal : Form
    {
        int sel_idEmpleado = -1;
        int sel_numRow = -1;
        Modelo_Empleados empleadoSeleccionado = new Modelo_Empleados();

        public Principal()
        {
            InitializeComponent();
        }

        private void AGREGAR_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosEmpleado())
                return;
            Modelo_Empleados empleado = new Modelo_Empleados();

            empleado.Nombre_Completo = TB_NOM.Text;
            empleado.Fecha_Nac = DTP_FECHNAC.Value;
            empleado.CURP = TB_CURP.Text;
            empleado.Email = TB_EMAIL.Text;
            empleado.ApellidoMaterno = TB_APMAT.Text;
            empleado.ApellidoPaterno = TB_APPAT.Text;
            empleado.NSS = TB_NSS.Text;
            empleado.RFC = TB_RFC.Text;
            empleado.Telefono = TB_TEL.Text;
            empleado.Contraseña = TB_PSW.Text;
            empleado.DomicilioCompleto = TB_DOM.Text;
            empleado.Banco = TB_BANCO.Text;
            empleado.NumeroCuenta = TB_NUMCUENTA.Text;
            empleado.FechaIngreso = DateTime.Now;
            empleado.PuestoID = (int)CB_PUESTO.SelectedValue;
            empleado.DepartamentoID = (int)CB_DPTO.SelectedValue;

            EmpleadoDAO.sp_gestion_empleado(empleado,"AGREGAR");
            Principal_Load(sender,e);
        }

        private void MODIFY_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosEmpleado())
                return;
            if (sel_numRow != -1)
            {
                Modelo_Empleados empleado = new Modelo_Empleados();

                empleado.Num_Empleado = int.Parse(DG_1.Rows[sel_numRow].Cells["NUM_EMPLEADO"].Value.ToString());
                empleado.Nombre_Completo = DG_1.Rows[sel_numRow].Cells["NOMBRE_COMPLETO"].Value.ToString();
                empleado.Fecha_Nac = Convert.ToDateTime(DG_1.Rows[sel_numRow].Cells["FECHA_NAC"].Value.ToString());
                empleado.CURP = DG_1.Rows[sel_numRow].Cells["CURP"].Value.ToString();
                empleado.Email = DG_1.Rows[sel_numRow].Cells["EMAIL"].Value.ToString();
                empleado.ApellidoMaterno = DG_1.Rows[sel_numRow].Cells["ApellidoMaterno"].Value.ToString();
                empleado.ApellidoPaterno = DG_1.Rows[sel_numRow].Cells["ApellidoPaterno"].Value.ToString();
                empleado.NSS = DG_1.Rows[sel_numRow].Cells["NSS"].Value.ToString();
                empleado.RFC = DG_1.Rows[sel_numRow].Cells["RFC"].Value.ToString();
                empleado.Telefono = DG_1.Rows[sel_numRow].Cells["Telefono"].Value.ToString();
                empleado.Contraseña = DG_1.Rows[sel_numRow].Cells["Contraseña"].Value.ToString();
                empleado.DomicilioCompleto = DG_1.Rows[sel_numRow].Cells["DomicilioCompleto"].Value.ToString();
                empleado.Banco = DG_1.Rows[sel_numRow].Cells["Banco"].Value.ToString();
                empleado.NumeroCuenta = DG_1.Rows[sel_numRow].Cells["NumeroCuenta"].Value.ToString();
                empleado.FechaIngreso = Convert.ToDateTime(DG_1.Rows[sel_numRow].Cells["FechaIngreso"].Value.ToString());
                empleado.PuestoID = int.Parse(DG_1.Rows[sel_numRow].Cells["PuestoID"].Value.ToString());
                empleado.DepartamentoID = int.Parse(DG_1.Rows[sel_numRow].Cells["DepartamentoID"].Value.ToString());

                sel_numRow = -1;
                EmpleadoDAO.sp_gestion_empleado(empleado, "MODIFICAR");
                MessageBox.Show("Empleado modificado");

                Principal_Load(sender, e);
            }
            else
                MessageBox.Show("Selecciona un empleado para modificarlo");
        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {
           
            if (sel_idEmpleado != -1)
            {
                Modelo_Empleados empleado = new Modelo_Empleados();
                empleado.Num_Empleado = sel_idEmpleado;

                try
                {
                    EmpleadoDAO.sp_gestion_empleado(empleado, "ELIMINAR");

                    MessageBox.Show("El usuario ha sido dado de baja.");
                    sel_idEmpleado = -1;

                    Principal_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            List<Modelo_Empleados> empleadosData = EmpleadoDAO.sp_get_empleado("");
            List<Modelo_Puestos> puestosData = PuestosDAO.get_puestos();
            List<Modelo_Departamentos> departamentosData = DepartamentosDAO.get_departamentos();

            TB_NUMEMP.Enabled = false;
            DG_1.DataSource = empleadosData;

            CB_PUESTO.DataSource = puestosData;
            CB_PUESTO.DisplayMember = "Nombre";
            CB_PUESTO.ValueMember = "ID_Puesto";

            CB_DPTO.DataSource = departamentosData;
            CB_DPTO.DisplayMember = "Nombre";
            CB_DPTO.ValueMember = "ID_Departamento";



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

        private void TB_NOM_TextChanged(object sender, EventArgs e)
        {

        }

        private void DG_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;
            sel_idEmpleado = int.Parse(DG_1.Rows[sel_numRow].Cells["NUM_EMPLEADO"].Value.ToString());
            //
            TB_NOM.Enabled = false;
            TB_APMAT.Enabled = false;
            TB_TEL.Enabled = false;
            TB_APPAT.Enabled = false;
            TB_CURP.Enabled = false;
            TB_EMAIL.Enabled = false;
            TB_NUMEMP.Enabled = false;
            TB_PSW.Enabled = false;
            TB_DOM.Enabled = false;
            TB_NSS.Enabled = false;
            TB_RFC.Enabled = false;
            TB_BANCO.Enabled = false;
            TB_NUMCUENTA.Enabled = false;
            CB_DPTO.Enabled = false;
            CB_PUESTO.Enabled = false;
            DTP_FECHNAC.Enabled = false;

            TB_NOM.Text = DG_1.Rows[sel_numRow].Cells["NOMBRE_COMPLETO"].Value.ToString();
            TB_APMAT.Text = DG_1.Rows[sel_numRow].Cells["ApellidoMaterno"].Value.ToString();
            TB_TEL.Text = DG_1.Rows[sel_numRow].Cells["Telefono"].Value.ToString();
            TB_APPAT.Text = DG_1.Rows[sel_numRow].Cells["ApellidoPaterno"].Value.ToString();
            TB_CURP.Text = DG_1.Rows[sel_numRow].Cells["CURP"].Value.ToString();
            TB_EMAIL.Text = DG_1.Rows[sel_numRow].Cells["EMAIL"].Value.ToString();
            TB_NUMEMP.Text = DG_1.Rows[sel_numRow].Cells["NUM_EMPLEADO"].Value.ToString();
            TB_PSW.Text = DG_1.Rows[sel_numRow].Cells["Contraseña"].Value.ToString();
            CB_DPTO.Text = DG_1.Rows[sel_numRow].Cells["DepartamentoID"].Value.ToString();
            CB_PUESTO.Text = DG_1.Rows[sel_numRow].Cells["PuestoID"].Value.ToString();
            TB_DOM.Text = DG_1.Rows[sel_numRow].Cells["DomicilioCompleto"].Value.ToString();
            TB_NSS.Text = DG_1.Rows[sel_numRow].Cells["NSS"].Value.ToString();
            TB_RFC.Text = DG_1.Rows[sel_numRow].Cells["RFC"].Value.ToString();
            TB_BANCO.Text = DG_1.Rows[sel_numRow].Cells["Banco"].Value.ToString();
            TB_NUMCUENTA.Text = DG_1.Rows[sel_numRow].Cells["NumeroCuenta"].Value.ToString();
            DTP_FECHNAC.Text = DG_1.Rows[sel_numRow].Cells["FECHA_NAC"].Value.ToString();



        }

        private void TB_DOM_TextChanged(object sender, EventArgs e)
        {

        }

        private void DG_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CB_DPTO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarDatosEmpleado()
        {
            // Validar nombre
            if (string.IsNullOrWhiteSpace(TB_NOM.Text))
            {
                MessageBox.Show("El nombre del empleado es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar CURP
            if (string.IsNullOrWhiteSpace(TB_CURP.Text) || TB_CURP.Text.Length != 18)
            {
                MessageBox.Show("El CURP debe tener 18 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar correo electrónico
            if (string.IsNullOrWhiteSpace(TB_EMAIL.Text) || !TB_EMAIL.Text.Contains("@"))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar NSS
            if (string.IsNullOrWhiteSpace(TB_NSS.Text) || TB_NSS.Text.Length != 11)
            {
                MessageBox.Show("El NSS debe tener 11 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar RFC
            if (string.IsNullOrWhiteSpace(TB_RFC.Text) || TB_RFC.Text.Length != 13)
            {
                MessageBox.Show("El RFC debe tener 13 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar banco
            if (string.IsNullOrWhiteSpace(TB_BANCO.Text))
            {
                MessageBox.Show("El banco es obligatorio.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar número de cuenta
            if (string.IsNullOrWhiteSpace(TB_NUMCUENTA.Text) || !TB_NUMCUENTA.Text.All(char.IsDigit))
            {
                MessageBox.Show("El número de cuenta debe ser numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar puesto y departamento
            if (CB_PUESTO.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un puesto.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CB_DPTO.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un departamento.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // Si todo está bien
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB_NOM.Text = "";
            TB_APMAT.Text = "";
            TB_TEL.Text = "";
            TB_APPAT.Text = "";
            TB_CURP.Text = "";
            TB_EMAIL.Text = "";
            TB_NUMEMP.Text = "";
            TB_PSW.Text = "";
            TB_DOM.Text = "";
            TB_NSS.Text = "";
            TB_RFC.Text = "";
            TB_BANCO.Text = "";
            TB_NUMCUENTA.Text = "";
            CB_DPTO.SelectedIndex = -1;
            CB_PUESTO.SelectedIndex = -1;
            DTP_FECHNAC.Value = DateTime.Now;

            TB_NOM.Enabled = true;
            TB_APMAT.Enabled = true;
            TB_TEL.Enabled = true;
            TB_APPAT.Enabled = true;
            TB_CURP.Enabled = true;
            TB_EMAIL.Enabled = true;
            TB_NUMEMP.Enabled = true;
            TB_PSW.Enabled = true;
            TB_DOM.Enabled = true;
            TB_NSS.Enabled = true;
            TB_RFC.Enabled = true;
            TB_BANCO.Enabled = true;
            TB_NUMCUENTA.Enabled = true;
            CB_DPTO.Enabled = true;
            CB_PUESTO.Enabled = true;
            DTP_FECHNAC.Enabled = true;


        }
    }
}
