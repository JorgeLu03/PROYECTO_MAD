using PROYECTO_MAD.PANTALLAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.DAO
{
    public class PantallasDAO
    {
        public static Departamentos pantallaDepartamentos = new Departamentos();
        public static Empresa pantallaEmpresa = new Empresa();
        Login pantallaLogin = new Login();
        Puestos pantallaPuestos = new Puestos();
        Percepciones_y_deducciones pantallaPercepciones = new Percepciones_y_deducciones();
        Reporte_Gral_Nómina pantallaReporteGralNomina = new Reporte_Gral_Nómina();
        Reporte_nómina pantallaReporteNomina = new Reporte_nómina();
        Reporte_Puesto_y_dpt pantallaReportePuestoDpt = new Reporte_Puesto_y_dpt();
        STRIPMENU pantallaMenu = new STRIPMENU();
        Principal pantallaGerente = new Principal();
        Empleado pantallaEmpleado = new Empleado();

    }
}
