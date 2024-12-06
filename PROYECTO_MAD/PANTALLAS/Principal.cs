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
        List<Modelo_Empleados> empleadosData = new List<Modelo_Empleados> ();
        List<Modelo_Puestos> puestosData = new List<Modelo_Puestos> ();
        List<Modelo_Departamentos> departamentosData = new List<Modelo_Departamentos> ();
        int sel_numRow = -1;
        Modelo_Empleados empleadoSeleccionado = new Modelo_Empleados();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            TB_USER.Text = string.Empty;
            TB_PSW.Text = string.Empty;
            TB_NOM.Text = string.Empty;
            TB_APPAT.Text = string.Empty;
            TB_APMAT.Text = string.Empty;
            TB_CURP.Text = string.Empty;
            TB_NSS.Text = string.Empty;
            TB_RFC.Text = string.Empty;
            TB_DOM.Text = string.Empty;
            TB_BANCO.Text = string.Empty;
            TB_NUMCUENTA.Text = string.Empty;
            TB_EMAIL.Text = string.Empty;
            TB_TEL.Text = string.Empty;
            AGREGAR.Enabled = true;
            MODIFY.Enabled = false;
            ELIMINAR.Enabled = false;

            empleadosData = EmpleadoDAO.sp_get_empleado("");
            puestosData = PuestosDAO.sp_get_puestos("");
            departamentosData = DepartamentosDAO.sp_get_departamentos("");

            //TB_NUMEMP.Enabled = false;
            DG_1.DataSource = empleadosData;

            CB_PUESTO.DataSource = puestosData;
            CB_PUESTO.DisplayMember = "nombre_puesto";
            CB_PUESTO.ValueMember = "id_puesto";

            CB_DPTO.DataSource = departamentosData;
            CB_DPTO.DisplayMember = "nombre_departamento";
            CB_DPTO.ValueMember = "id_departamento";
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            List<Modelo_Empleados> empleadosData = EmpleadoDAO.sp_get_empleado(TB_BUSCAR.Text);
            DG_1.DataSource = empleadosData;
        }

        private void DG_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;

            int sel_empleado = int.Parse(DG_1.Rows[sel_numRow].Cells["id_empleado"].Value.ToString());
            empleadoSeleccionado = empleadosData.FirstOrDefault(x => x.id_empleado == sel_empleado);

            CB_DPTO.SelectedValue = empleadoSeleccionado.id_departamento;
            CB_PUESTO.SelectedValue = empleadoSeleccionado.id_puesto;
            TB_USER.Text = empleadoSeleccionado.usuario;
            TB_PSW.Text = empleadoSeleccionado.contrasena;
            TB_NOM.Text = empleadoSeleccionado.nombre;
            TB_APPAT.Text = empleadoSeleccionado.apellido_paterno;
            TB_APMAT.Text = empleadoSeleccionado.apellido_materno;
            DTP_FECHNAC.Value = empleadoSeleccionado.fecha_nacimiento;
            TB_CURP.Text = empleadoSeleccionado.curp;
            TB_NSS.Text = empleadoSeleccionado.nss;
            TB_RFC.Text = empleadoSeleccionado.rfc;
            TB_DOM.Text = empleadoSeleccionado.domicilio;
            TB_BANCO.Text = empleadoSeleccionado.banco;
            TB_NUMCUENTA.Text = empleadoSeleccionado.numero_cuenta;
            TB_EMAIL.Text = empleadoSeleccionado.email;
            TB_TEL.Text = empleadoSeleccionado.telefono;

            AGREGAR.Enabled = false;
            MODIFY.Enabled = true;
            ELIMINAR.Enabled = true;
        }


        private void AGREGAR_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosEmpleado())
                return;
            Modelo_Empleados empleado = new Modelo_Empleados();

            empleado.id_empleado = 0;
            empleado.id_empresa = 1;
            empleado.id_departamento = (int)CB_DPTO.SelectedValue;
            empleado.id_puesto = (int)CB_PUESTO.SelectedValue;
            empleado.usuario = TB_USER.Text;
            empleado.contrasena = TB_PSW.Text;
            empleado.nombre = TB_NOM.Text;
            empleado.apellido_paterno = TB_APPAT.Text;
            empleado.apellido_materno =TB_APMAT.Text;
            empleado.fecha_nacimiento = DTP_FECHNAC.Value;
            empleado.curp = TB_CURP.Text;
            empleado.nss = TB_NSS.Text;
            empleado.rfc = TB_RFC.Text;
            empleado.domicilio = TB_DOM.Text;
            empleado.banco = TB_BANCO.Text;
            empleado.numero_cuenta = TB_NUMCUENTA.Text;
            empleado.email = TB_EMAIL.Text;
            empleado.telefono = TB_TEL.Text;
            empleado.fecha_contratacion = DateTime.Now;
            empleado.activo = true;

            Modelo_Empleados existe = empleadosData.FirstOrDefault(x => 
                (x.usuario == empleado.usuario || x.nss == empleado.nss || x.rfc == empleado.rfc || x.curp == empleado.curp || x.numero_cuenta == empleado.numero_cuenta) &&
                x.activo == true);

            if (existe != null)
            {
                MessageBox.Show("Ya existe un empleado con ese nombre, revise los campos.");
                return;
            }

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

                empleado.id_empleado = empleadoSeleccionado.id_empleado;
                empleado.id_empresa = empleadoSeleccionado.id_empresa;
                empleado.id_departamento = (int)CB_DPTO.SelectedValue;
                empleado.id_puesto = (int)CB_PUESTO.SelectedValue;
                empleado.usuario = TB_USER.Text;
                empleado.contrasena = TB_PSW.Text;
                empleado.nombre = TB_NOM.Text;
                empleado.apellido_paterno = TB_APPAT.Text;
                empleado.apellido_materno = TB_APMAT.Text;
                empleado.fecha_nacimiento = DTP_FECHNAC.Value;
                empleado.curp = TB_CURP.Text;
                empleado.nss = TB_NSS.Text;
                empleado.rfc = TB_RFC.Text;
                empleado.domicilio = TB_DOM.Text;
                empleado.banco = TB_BANCO.Text;
                empleado.numero_cuenta = TB_NUMCUENTA.Text;
                empleado.email = TB_EMAIL.Text;
                empleado.telefono = TB_TEL.Text;
                empleado.fecha_contratacion = empleadoSeleccionado.fecha_contratacion;
                empleado.activo = empleadoSeleccionado.activo;

                Modelo_Empleados existe = empleadosData.FirstOrDefault(x =>
                    x.id_empleado != empleado.id_empleado &&
                    (x.usuario == empleado.usuario || x.nss == empleado.nss || x.rfc == empleado.rfc || x.curp == empleado.curp || x.numero_cuenta == empleado.numero_cuenta) &&
                    x.activo == true);

                if (existe != null)
                {
                    MessageBox.Show("Ya existe un empleado con ese nombre, revise los campos.");
                    return;
                }

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
           
            if (sel_numRow != -1)
            {
                Modelo_Empleados empleado = new Modelo_Empleados();
                empleado.id_empleado = empleadoSeleccionado.id_empleado;

                try
                {
                    EmpleadoDAO.sp_gestion_empleado(empleado, "ELIMINAR");

                    MessageBox.Show("El usuario ha sido dado de baja.");
                    sel_numRow = -1;

                    Principal_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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

    }
}
