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
    public partial class Percepciones_y_deducciones : Form
    {
        List<Modelo_Percepcion> percepcionesData = new List<Modelo_Percepcion>();
        List<Modelo_Deduccion> deduccionesData = new List<Modelo_Deduccion>();
        Modelo_Percepcion percepcionSeleccionada = null;
        Modelo_Deduccion deduccionSeleccionada = null;
        string seleccion = string.Empty;
        int sel_numRow = -1;

        public Percepciones_y_deducciones()
        {
            InitializeComponent();
        }

        private void Percepciones_y_deducciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }

        private void Percepciones_y_deducciones_Load(object sender, EventArgs e)
        {
            CB_REG.SelectedIndex = 0;
            percepcionesData = PercepcionDeduccionDAO.sp_get_percepciones("");
            deduccionesData = PercepcionDeduccionDAO.sp_get_deducciones("");

            DGP.DataSource = percepcionesData;
            DGD.DataSource = deduccionesData;
        }

        private void TB_BUSCAR_TextChanged(object sender, EventArgs e)
        {
            percepcionesData = PercepcionDeduccionDAO.sp_get_percepciones(TB_BUSCAR.Text);
            deduccionesData = PercepcionDeduccionDAO.sp_get_deducciones(TB_BUSCAR.Text);

            DGP.DataSource = percepcionesData;
            DGD.DataSource = deduccionesData;
        }

        private void DGP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccion = "PERCEPCION";

            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;

            int sel_per = int.Parse(DGP.Rows[sel_numRow].Cells["id_percepcion"].Value.ToString());
            percepcionSeleccionada = percepcionesData.FirstOrDefault(x => x.id_percepcion == sel_per);

            CB_REG.SelectedIndex = 0;
            TB_NOM.Text = percepcionSeleccionada.nombre_percepcion;
            TB_CANT.Text = percepcionSeleccionada.monto.ToString();
            CB_POR.Checked = percepcionSeleccionada.es_porcentaje;

            BTN_ADD.Enabled = false;
            BTN_ELIM.Enabled = true;
        }

        private void DGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccion = "DEDUCCION";

            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;

            int sel_ded = int.Parse(DGD.Rows[sel_numRow].Cells["id_deduccion"].Value.ToString());
            deduccionSeleccionada = deduccionesData.FirstOrDefault(x => x.id_deduccion == sel_ded);

            CB_REG.SelectedIndex = 1;
            TB_NOM.Text = deduccionSeleccionada.nombre_deduccion;
            TB_CANT.Text = deduccionSeleccionada.monto.ToString();
            CB_POR.Checked = deduccionSeleccionada.es_porcentaje;

            BTN_ADD.Enabled = false;
            BTN_ELIM.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modelo_Percepcion per = new Modelo_Percepcion();
            Modelo_Deduccion ded = new Modelo_Deduccion();

            if (CB_REG.SelectedIndex == 0)
            {
                per.nombre_percepcion = TB_NOM.Text;
                per.es_porcentaje = CB_POR.Checked;
                per.monto = decimal.Parse(TB_CANT.Text);
                PercepcionDeduccionDAO.sp_gestion_percepcion(per, "AGREGAR");
            }
            else if (CB_REG.SelectedIndex == 1)
            {
                ded.nombre_deduccion = TB_NOM.Text;
                ded.es_porcentaje = CB_POR.Checked;
                ded.monto = decimal.Parse(TB_CANT.Text);
                PercepcionDeduccionDAO.sp_gestion_deduccion(ded, "AGREGAR");
            }

            Percepciones_y_deducciones_Load(sender, e);
        }

        private void BTN_ELIM_Click(object sender, EventArgs e)
        {
            if (sel_numRow != -1)
            {
                Modelo_Percepcion per = new Modelo_Percepcion();
                Modelo_Deduccion ded = new Modelo_Deduccion();


                if (seleccion == "PERCEPCION")
                {
                    per.id_percepcion = percepcionSeleccionada.id_percepcion;
                    try
                    {
                        PercepcionDeduccionDAO.sp_gestion_percepcion(per, "ELIMINAR");
                        MessageBox.Show("El departamento ha sido dado de baja.");
                        sel_numRow = -1;

                        Percepciones_y_deducciones_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
                else if (seleccion == "DEDUCCION")
                {
                    ded.id_deduccion = deduccionSeleccionada.id_deduccion;
                    try
                    {
                        PercepcionDeduccionDAO.sp_gestion_deduccion(ded, "ELIMINAR");
                        MessageBox.Show("El departamento ha sido dado de baja.");
                        sel_numRow = -1;

                        Percepciones_y_deducciones_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
