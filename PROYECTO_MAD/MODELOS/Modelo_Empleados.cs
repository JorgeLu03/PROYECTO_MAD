using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROYECTO_MAD.MODELOS
{
        public class Modelo_Empleados
        {
            public int Num_Empleado { get; set; }
            public string Nombre_Completo { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public DateTime Fecha_Nac { get; set; }
            public string CURP { get; set; }
            public string Email { get; set; }
            public string NSS { get; set; }
            public string RFC { get; set; }
            public string Telefono { get; set; }
            public string Contraseña { get; set; }
            public string DomicilioCompleto { get; set; }
            public string Banco { get; set; }
            public string NumeroCuenta { get; set; }
            public DateTime FechaIngreso { get; set; }
            public int PuestoID { get; set; }
            public int DepartamentoID { get; set; }

            public Modelo_Empleados()
            {
            }
            public Modelo_Empleados(int num_Empleado, string nombre_Completo, DateTime fecha_Nac, string cURP, string email)
            {
                Num_Empleado = num_Empleado;
                Nombre_Completo = nombre_Completo;
                Fecha_Nac = fecha_Nac;
                CURP = cURP;
                Email = email;
            }
        }
}
