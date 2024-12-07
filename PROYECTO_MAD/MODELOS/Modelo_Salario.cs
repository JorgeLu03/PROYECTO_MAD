using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_Salario
    {
        public int ID_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public decimal Sueldo_Base_Diario { get; set; }
        public decimal Proporcion_Sueldo { get; set; }
        public decimal Sueldo_Bruto { get; set; }
        public decimal Sueldo_Bruto_Mensual { get; set; }
        public decimal percepciones { get; set; }
        public decimal deducciones { get; set; }
        public decimal Sueldo_Neto_Mensual { get; set; }

        public Modelo_Salario(int iD_Empleado, string nombre, string apellido_Paterno, string apellido_Materno, decimal sueldo_Base_Diario, decimal proporcion_Sueldo, decimal sueldo_Bruto, decimal sueldo_Bruto_Mensual, decimal percepciones, decimal deducciones, decimal sueldo_Neto_Mensual)
        {
            ID_Empleado = iD_Empleado;
            Nombre = nombre;
            Apellido_Paterno = apellido_Paterno;
            Apellido_Materno = apellido_Materno;
            Sueldo_Base_Diario = sueldo_Base_Diario;
            Proporcion_Sueldo = proporcion_Sueldo;
            Sueldo_Bruto = sueldo_Bruto;
            Sueldo_Bruto_Mensual = sueldo_Bruto_Mensual;
            this.percepciones = percepciones;
            this.deducciones = deducciones;
            Sueldo_Neto_Mensual = sueldo_Neto_Mensual;
        }

        public Modelo_Salario()
        {
            
        }
    }


}
