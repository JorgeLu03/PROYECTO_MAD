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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_MAD.PANTALLAS
{
    public partial class Departamentos : Form
    {
        List<Modelo_Departamentos> departamentosData = new List<Modelo_Departamentos>();
        Modelo_Departamentos departamentoSeleccionado = new Modelo_Departamentos();
        int sel_idDpto = -1;
        int sel_numRow = -1;

        public Departamentos()
        {
            InitializeComponent();
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            TB_DEP.Text = "";
            TB_SUELDO.Text = "";
            BTN_ADD.Enabled = true;
            BTN_EDIT.Enabled = false;
            BTN_ELIM.Enabled = false;

            departamentosData = DepartamentosDAO.sp_get_departamentos("");
            DG_2.DataSource = departamentosData;
        }

        private void Departamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }

        private void TB_BUSCAR_TextChanged(object sender, EventArgs e)
        {
            List<Modelo_Departamentos> departamentosData = DepartamentosDAO.sp_get_departamentos(TB_BUSCAR.Text);
            DG_2.DataSource = departamentosData;
        }

        private void DG_2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;

            sel_idDpto = int.Parse(DG_2.Rows[sel_numRow].Cells["id_departamento"].Value.ToString());
            departamentoSeleccionado = departamentosData.FirstOrDefault(x => x.id_departamento == sel_idDpto);

            TB_DEP.Text = departamentoSeleccionado.nombre_departamento;
            TB_SUELDO.Text = departamentoSeleccionado.sueldo_base_diario.ToString();

            BTN_ADD.Enabled = false;
            BTN_EDIT.Enabled = true;
            BTN_ELIM.Enabled = true;
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            Modelo_Departamentos dpto = new Modelo_Departamentos();

            dpto.nombre_departamento = TB_DEP.Text;
            dpto.sueldo_base_diario = decimal.Parse(TB_SUELDO.Text);

            Modelo_Departamentos existe = departamentosData.FirstOrDefault(x => x.nombre_departamento == dpto.nombre_departamento && x.activo == true);

            if(existe != null)
            {
                MessageBox.Show("Ya existe un departamento con ese nombre, jaja saludos.");
                return;
            }

            DepartamentosDAO.sp_gestion_departamento(dpto, "AGREGAR");
            Departamentos_Load(sender, e);
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (sel_numRow != -1) // Asegúrate de que se ha seleccionado una fila
            {
                // Crear una instancia del modelo de departamentos
                Modelo_Departamentos departamento = new Modelo_Departamentos();

                // Llenar las propiedades del modelo con los valores seleccionados en el DataGridView
                departamento.id_departamento = departamentoSeleccionado.id_departamento;
                departamento.nombre_departamento = TB_DEP.Text;
                departamento.sueldo_base_diario = decimal.Parse(TB_SUELDO.Text);
                departamento.id_empresa = departamentoSeleccionado.id_empresa;
                departamento.activo = departamentoSeleccionado.activo;

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

        private void BTN_ELIM_Click(object sender, EventArgs e)
        {
            if (sel_idDpto != -1)
            {
                Modelo_Departamentos dpto = new Modelo_Departamentos();
                dpto.id_departamento = departamentoSeleccionado.id_departamento;

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

    }
}
