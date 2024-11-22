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
            List<Modelo_Puestos> puestos = PuestosDAO.get_puestos();
            CB_TIPO.DataSource = puestos;
            CB_TIPO.DisplayMember = "Nombre";
            CB_TIPO.ValueMember = "ID_Puesto";       
        }

        private void BTN_INICSES_Click(object sender, EventArgs e)
        {
            int tipo = (int)CB_TIPO.SelectedValue;
            string usuario= TB_USER.Text;
            string contraseña = TB_PSW.Text;

            // Llamar al procedimiento almacenado
            Modelo_Empleados empleado = EmpleadoDAO.sp_get_empleado_login(usuario, contraseña,tipo);

            if (empleado != null)
            {
               Modelo_Departamentos departamento = DepartamentosDAO.sp_get_departamento(empleado.DepartamentoID);
               Modelo_Puestos puesto = PuestosDAO.sp_get_puestoEmpleado(empleado.PuestoID);


                MessageBox.Show($"¡Bienvenido {empleado.Nombre_Completo}!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Sesion.empleado = empleado;
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
    }
}
