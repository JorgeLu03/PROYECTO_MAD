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

namespace PROYECTO_MAD.PANTALLAS
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void Empleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {

        }

        private void BTN_IMPRIMIR_Click(object sender, EventArgs e)
        {
            Modelo_Salario SalarioBruto= SalarioDAO.sp_get_salario_bruto(30,Sesion.empleado.id_empleado);
            List<Modelo_Percepcion> percepciones = PercepcionDeduccionDAO.sp_get_percepciones("");
            List<Modelo_Deduccion> deducciones = PercepcionDeduccionDAO.sp_get_deducciones("");
            foreach (Modelo_Percepcion item in percepciones) 
            {
                //SalarioBruto.Sueldo_Neto = ;
            }
            foreach (Modelo_Deduccion item in deducciones) 
            {
                //SalarioBruto.Sueldo_Neto = ;

            }

        }
    }
}
