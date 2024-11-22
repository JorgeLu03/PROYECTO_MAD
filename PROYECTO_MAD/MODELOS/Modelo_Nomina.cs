using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_Nomina
    {
        // Propiedades
        public int ID_Nomina { get; set; }
        public int ID_Empleado { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public decimal SueldoBruto { get; set; }
        public decimal SueldoNeto { get; set; }
        public DateTime FechaPago { get; set; }

        // Constructor por defecto
        public Modelo_Nomina()
        {
        }

        // Constructor con parámetros
        public Modelo_Nomina(int id_Nomina, int id_Empleado, int mes, int año, decimal sueldoBruto, decimal sueldoNeto, DateTime fechaPago)
        {
            ID_Nomina = id_Nomina;
            ID_Empleado = id_Empleado;
            Mes = mes;
            Año = año;
            SueldoBruto = sueldoBruto;
            SueldoNeto = sueldoNeto;
            FechaPago = fechaPago;
        }
    }

}
