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
    public partial class Puestos : Form
    {
        int sel_idPuesto = -1;
        int sel_numRow = -1;
        Modelo_Puestos puestoSeleccionado = new Modelo_Puestos();
        public Puestos()
        {
            InitializeComponent();
        }

        private void Puestos_Load(object sender, EventArgs e)
        {
            List<Modelo_Puestos> puestosData = PuestosDAO.sp_get_puestoEmpleado2("");
            List<Modelo_Departamentos> departamentosData = DepartamentosDAO.get_departamentos();

            DG_3.DataSource = puestosData;
            CB_NOMPUES.DataSource = departamentosData;
            CB_NOMPUES.DisplayMember = "Nombre";
            CB_NOMPUES.ValueMember = "ID_Departamento";
        }

        private void Puestos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            if (CB_NOMPUES.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un departamento.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TB_PUESTO.Text))
            {
                MessageBox.Show("El nombre del puesto no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(TB_SALARIO.Text, out decimal nivelSalarial) || nivelSalarial <= 0)
            {
                MessageBox.Show("El nivel salarial debe ser un número válido mayor a cero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Modelo_Puestos puesto = new Modelo_Puestos();

            puesto.Nombre = TB_PUESTO.Text;
            puesto.NivelSalarial = decimal.Parse (TB_SALARIO.Text);
            puesto.ID_Departamento=(int)CB_NOMPUES.SelectedValue;
            PuestosDAO.sp_gestion_puesto(puesto, "AGREGAR");
            Puestos_Load(sender, e);
        }

        private void CB_NOMPUES_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_ELIM_Click(object sender, EventArgs e)
        {
            if (sel_idPuesto != -1)
            {
                Modelo_Puestos puesto = new Modelo_Puestos();
                puesto.ID_Puesto = sel_idPuesto;

                try
                {
                    PuestosDAO.sp_gestion_puesto(puesto, "ELIMINAR");

                    MessageBox.Show("El puesto ha sido dado de baja.");
                    sel_idPuesto = -1;

                    Puestos_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Puestos_Click(object sender, EventArgs e)
        {

        }

        private void DG_3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CB_NOMPUES.Enabled = false;
            TB_PUESTO.Enabled = false;
            TB_SALARIO.Enabled = false;
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;
            sel_idPuesto = int.Parse(DG_3.Rows[sel_numRow].Cells["ID_Puesto"].Value.ToString());

            TB_PUESTO.Text = DG_3.Rows[sel_numRow].Cells["Nombre"].Value.ToString();

            TB_SALARIO.Text = DG_3.Rows[sel_numRow].Cells["NivelSalarial"].Value.ToString();

            int idDepartamento = int.Parse(DG_3.Rows[sel_numRow].Cells["ID_Departamento"].Value.ToString());
            CB_NOMPUES.SelectedValue = idDepartamento; // Selecciona el departamento basado en su ID
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (sel_numRow != -1) // Asegúrate de que se ha seleccionado una fila
            {
                // Crear una instancia del modelo de puestos
                Modelo_Puestos puesto = new Modelo_Puestos();

                // Llenar las propiedades del modelo con los valores seleccionados en el DataGridView
                puesto.ID_Puesto = int.Parse(DG_3.Rows[sel_numRow].Cells["ID_Puesto"].Value.ToString());
                puesto.Nombre = DG_3.Rows[sel_numRow].Cells["Nombre"].Value.ToString();
                puesto.NivelSalarial = decimal.Parse(DG_3.Rows[sel_numRow].Cells["NivelSalarial"].Value.ToString());
                puesto.ID_Departamento = int.Parse(DG_3.Rows[sel_numRow].Cells["ID_Departamento"].Value.ToString());

                // Restablecer la fila seleccionada
                sel_numRow = -1;

                // Llamar al procedimiento almacenado para modificar el puesto
                PuestosDAO.sp_gestion_puesto(puesto, "MODIFICAR");
                MessageBox.Show("Puesto modificado");

                // Recargar la interfaz principal
                Puestos_Load(sender, e);
            }
            else
            {
                // Mostrar un mensaje si no se seleccionó ninguna fila
                MessageBox.Show("Selecciona un puesto para modificarlo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CB_NOMPUES.SelectedIndex = -1;
            TB_PUESTO.Text = "";
            TB_SALARIO.Text = "";

            CB_NOMPUES.Enabled = true;
            TB_PUESTO.Enabled = true;
            TB_SALARIO.Enabled = true;
        }
    }
}
