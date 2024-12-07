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
    public partial class Reporte_nómina : Form
    {
        List<Modelo_Empleados> empleadosData = new List<Modelo_Empleados>();
        List<Modelo_Mes> mesesData = new List<Modelo_Mes>();
        List<Modelo_Nomina> nominasData = new List<Modelo_Nomina>();
        int sel_numRow = -1;
        Modelo_Empleados empleadoSeleccionado = new Modelo_Empleados();
        public Reporte_nómina()
        {
            InitializeComponent();
        }

        private void Reporte_nómina_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }

        private void Reporte_nómina_Load(object sender, EventArgs e)
        {
            empleadosData = EmpleadoDAO.sp_get_empleado("");
            DG_1.DataSource = empleadosData;

            DTP_AÑO.Format = DateTimePickerFormat.Custom;
            DTP_AÑO.CustomFormat = "yyyy";  // Muestra solo el año
            DTP_AÑO.ShowUpDown = true; // Usar flechas para cambiar el año

            mesesData = PercepcionDeduccionDAO.sp_get_meses();
            CB_MES.DataSource = mesesData;
            CB_MES.DisplayMember = "nombre_mes";
            CB_MES.ValueMember = "numero_mes";
        }

        private void TB_BUSCAR_TextChanged(object sender, EventArgs e)
        {
            empleadosData = EmpleadoDAO.sp_get_empleado(TB_BUSCAR.Text);
            DG_1.DataSource = empleadosData;
        }

        private void DG_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel_numRow = e.RowIndex;

            if (sel_numRow < 0)
                return;

            int sel_empleado = int.Parse(DG_1.Rows[sel_numRow].Cells["id_empleado"].Value.ToString());
            empleadoSeleccionado = empleadosData.FirstOrDefault(x => x.id_empleado == sel_empleado);

            nominasData = PercepcionDeduccionDAO.sp_get_nomina_empleado(sel_empleado);
            List<Modelo_Nomina> nominasEmpleado = nominasData.Where(x => x.id_empleado == sel_empleado).ToList();
            DG_NOM.DataSource = nominasEmpleado;

            int diasSeleccionado = mesesData.FirstOrDefault(x => x.nombre_mes == CB_MES.Text).dias_mes;

            Modelo_Salario salarioData = SalarioDAO.sp_get_salario_bruto(diasSeleccionado, empleadoSeleccionado.id_empleado);
            salarioData = SalarioDAO.calcula_percepciones_deducciones(salarioData);

            TB_BRUTO.Text = salarioData.Sueldo_Bruto_Mensual.ToString();
            TB_NETO.Text = salarioData.Sueldo_Neto_Mensual.ToString();

            BTN_GENREPORTE.Enabled = true;
        }

        private void CB_MES_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sel_numRow > 0)
            {
                int diasSeleccionado = mesesData.FirstOrDefault(x => x.nombre_mes == CB_MES.Text).dias_mes;

                Modelo_Salario salarioData = SalarioDAO.sp_get_salario_bruto(diasSeleccionado, empleadoSeleccionado.id_empleado);
                salarioData = SalarioDAO.calcula_percepciones_deducciones(salarioData);

                TB_BRUTO.Text = salarioData.Sueldo_Bruto_Mensual.ToString();
                TB_NETO.Text = salarioData.Sueldo_Neto_Mensual.ToString();
            }
        }

        private void BTN_GENREPORTE_Click(object sender, EventArgs e)
        {
            Modelo_Nomina nomina = new Modelo_Nomina();

            int mesSeleccionado = mesesData.FirstOrDefault(x => x.nombre_mes == CB_MES.Text).numero_mes;

            nomina.id_empleado = empleadoSeleccionado.id_empleado;
            nomina.nombre_mes = CB_MES.Text;
            nomina.fecha_pago = new DateTime(DTP_AÑO.Value.Year, mesSeleccionado, 25); ;
            nomina.sueldo_bruto = decimal.Parse(TB_BRUTO.Text);
            nomina.sueldo_neto = decimal.Parse(TB_NETO.Text);

            Modelo_Nomina existe = nominasData.FirstOrDefault(x => x.id_empleado == empleadoSeleccionado.id_empleado && x.fecha_pago == nomina.fecha_pago);

            if (existe != null)
            {
                MessageBox.Show("Ya existe una noimina en ese mes y año.");
                return;
            }

            PercepcionDeduccionDAO.sp_gestion_nomina("AGREGAR", nomina);
            Reporte_nómina_Load(sender, e);
        }
    }
}
