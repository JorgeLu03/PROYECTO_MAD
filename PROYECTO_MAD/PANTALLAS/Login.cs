using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_MAD.PANTALLAS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CB_TIPO_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
            List<Modelo_Puestos> puestos = PuestosDAO.sp_get_puestos("");
            CB_TIPO.DataSource = puestos;
            CB_TIPO.DisplayMember = "nombre_puesto";
            CB_TIPO.ValueMember = "id_puesto";
        }

        private void BTN_INICSES_Click(object sender, EventArgs e)
        {
            Modelo_Empleados login = new Modelo_Empleados();
            login.usuario = TB_USER.Text;
            login.contrasena = TB_PSW.Text;
            login.id_puesto = (int)CB_TIPO.SelectedValue;

            // Llamar al procedimiento almacenado
            Modelo_Empleados empleado = EmpleadoDAO.sp_get_empleado_login(login);

            if (empleado != null)
            {
                Modelo_Departamentos departamento = DepartamentosDAO.sp_get_departamento_login(empleado.id_departamento);
                Modelo_Puestos puesto = PuestosDAO.sp_get_puesto_login(empleado.id_puesto);
                string nombreCompleto = $"{empleado.nombre} {empleado.apellido_paterno} {empleado.apellido_materno}";
                
                MessageBox.Show($"¡Bienvenido {nombreCompleto}!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Sesion.empleado = empleado;
                Sesion.puesto = puesto;
                Sesion.departamento = departamento;
                this.Hide();
                Principal_Todos pantallaPrincipal = new Principal_Todos();
                pantallaPrincipal.ShowDialog();
            }
            else
            {
                // Usuario o contraseña incorrectos
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intenta de nuevo.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TB_USER_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
