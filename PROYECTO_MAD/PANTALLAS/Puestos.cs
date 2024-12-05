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
        List<Modelo_Puestos> puestosData = new List<Modelo_Puestos>();
        Modelo_Puestos puestoSeleccionado = new Modelo_Puestos();
        //int sel_idPuesto = -1;
        int sel_numRow = -1;
        public Puestos()
        {
            InitializeComponent();
        }

        private void Puestos_Load(object sender, EventArgs e)
        {
            TB_PUESTO.Text = string.Empty;
            TB_SALARIO.Text = string.Empty;
            BTN_ADD.Enabled = true;
            BTN_EDIT.Enabled = false;
            BTN_ELIM.Enabled = false;

            puestosData = PuestosDAO.sp_get_puestos("");

            DG_3.DataSource = puestosData;
            //List<Modelo_Departamentos> departamentosData = DepartamentosDAO.get_departamentos();
            //CB_NOMPUES.DataSource = departamentosData;
            //CB_NOMPUES.DisplayMember = "Nombre";
            //CB_NOMPUES.ValueMember = "ID_Departamento";
        }

        private void Puestos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }

        private void TB_BUSCAR_TextChanged(object sender, EventArgs e)
        {
            puestosData = PuestosDAO.sp_get_puestos(TB_BUSCAR.Text);
            DG_3.DataSource = puestosData;
        }

        private void DG_3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;

            int sel_idPuesto = int.Parse(DG_3.Rows[sel_numRow].Cells["id_puesto"].Value.ToString());
            puestoSeleccionado = puestosData.FirstOrDefault(x => x.id_puesto == sel_idPuesto);

            TB_PUESTO.Text = puestoSeleccionado.nombre_puesto;
            TB_SALARIO.Text = puestoSeleccionado.proporcion_sueldo.ToString();

            BTN_ADD.Enabled = false;
            BTN_EDIT.Enabled = true;
            BTN_ELIM.Enabled = true;
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            Modelo_Puestos puesto = new Modelo_Puestos();

            puesto.nombre_puesto = TB_PUESTO.Text;
            puesto.proporcion_sueldo = decimal.Parse(TB_SALARIO.Text);

            Modelo_Puestos existe = puestosData.FirstOrDefault(x => x.nombre_puesto == puesto.nombre_puesto && x.activo == true);

            if (existe != null)
            {
                MessageBox.Show("Ya existe un puesto con ese nombre.");
                return;
            }

            //puesto.ID_Departamento=(int)CB_NOMPUES.SelectedValue;
            PuestosDAO.sp_gestion_puesto(puesto, "AGREGAR");
            Puestos_Load(sender, e);
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (sel_numRow != -1) // Asegúrate de que se ha seleccionado una fila
            {
                // Crear una instancia del modelo de departamentos
                Modelo_Puestos puesto = new Modelo_Puestos();

                // Llenar las propiedades del modelo con los valores seleccionados en el DataGridView
                puesto.id_puesto = puestoSeleccionado.id_departamento;
                puesto.nombre_puesto = TB_PUESTO.Text;
                puesto.proporcion_sueldo = decimal.Parse(TB_SALARIO.Text);
                puesto.id_departamento = puestoSeleccionado.id_departamento;
                puesto.activo = puestoSeleccionado.activo;

                Modelo_Puestos existe = puestosData.FirstOrDefault(x => x.nombre_puesto == puesto.nombre_puesto && x.activo == true);

                if (existe != null)
                {
                    MessageBox.Show("Ya existe un departamento con ese nombre, jaja saludos.");
                    return;
                }

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

        private void BTN_ELIM_Click(object sender, EventArgs e)
        {
            if (sel_numRow != -1)
            {
                Modelo_Puestos puesto = new Modelo_Puestos();
                puesto.id_puesto = puestoSeleccionado.id_puesto;

                try
                {
                    PuestosDAO.sp_gestion_puesto(puesto, "ELIMINAR");

                    MessageBox.Show("El puesto ha sido dado de baja.");
                    sel_numRow = -1;

                    Puestos_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
