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
    public partial class Departamentos : Form
    {
        int sel_idDpto = -1;
        int sel_numRow = -1;
        Modelo_Departamentos departamentoSeleccionado = new Modelo_Departamentos();

        public Departamentos()
        {
            InitializeComponent();
        }

        private void Departamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Departamentos_Load(object sender, EventArgs e)
        {
            List<Modelo_Departamentos> departamentosData = DepartamentosDAO.sp_get_departamento2("");
            DG_2.DataSource = departamentosData;
           


        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_DEP.Text))
            {
                MessageBox.Show("El nombre del departamento no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el campo TB_SUELDO tenga un valor decimal válido
            if (!decimal.TryParse(TB_SUELDO.Text, out decimal sueldoBase) || sueldoBase <= 0)
            {
                MessageBox.Show("El sueldo base debe ser un número mayor a cero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Modelo_Departamentos dpto = new Modelo_Departamentos();

            dpto.Nombre = TB_DEP.Text;
            dpto.SueldoBase = decimal.Parse(TB_SUELDO.Text);
           
            DepartamentosDAO.sp_gestion_departamento(dpto, "AGREGAR");
            Departamentos_Load(sender, e);
        }

        private void BTN_ELIM_Click(object sender, EventArgs e)
        {
            if (sel_idDpto != -1)
            {
                Modelo_Departamentos dpto = new Modelo_Departamentos();
                dpto.ID_Departamento = sel_idDpto;

                try
                {
                    DepartamentosDAO.sp_gestion_departamento(dpto, "ELIMINAR");

                    MessageBox.Show("El departamento ha sido dado de baja.");
                    sel_idDpto = -1;

                    Departamentos_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DG_2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_DEP.Enabled = false;
            TB_SUELDO.Enabled = false;
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;
            sel_idDpto = int.Parse(DG_2.Rows[sel_numRow].Cells["ID_Departamento"].Value.ToString());

            TB_DEP.Text = DG_2.Rows[sel_numRow].Cells["Nombre"].Value.ToString();
            TB_SUELDO.Text = DG_2.Rows[sel_numRow].Cells["SueldoBase"].Value.ToString();
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (sel_numRow != -1) // Asegúrate de que se ha seleccionado una fila
            {
                // Crear una instancia del modelo de departamentos
                Modelo_Departamentos departamento = new Modelo_Departamentos();

                // Llenar las propiedades del modelo con los valores seleccionados en el DataGridView
                departamento.ID_Departamento = int.Parse(DG_2.Rows[sel_numRow].Cells["ID_Departamento"].Value.ToString());
                departamento.Nombre = DG_2.Rows[sel_numRow].Cells["Nombre"].Value.ToString();
                departamento.SueldoBase = decimal.Parse(DG_2.Rows[sel_numRow].Cells["SueldoBase"].Value.ToString());

                // Restablecer la fila seleccionada
                sel_numRow = -1;

                // Llamar al procedimiento almacenado para modificar el departamento
                DepartamentosDAO.sp_gestion_departamento(departamento, "MODIFICAR");
                MessageBox.Show("Departamento modificado");

                // Recargar la interfaz principal
                Departamentos_Load(sender, e);
            }
            else
            {
                // Mostrar un mensaje si no se seleccionó ninguna fila
                MessageBox.Show("Selecciona un departamento para modificarlo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB_DEP.Text= "";
            TB_SUELDO.Text = "";
            TB_DEP.Enabled = true;
            TB_SUELDO.Enabled = true;

        }
    }
}
