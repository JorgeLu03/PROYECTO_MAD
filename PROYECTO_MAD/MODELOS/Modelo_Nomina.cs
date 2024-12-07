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
        public int id_nomina { get; set; }
        public int id_empleado { get; set; }
        public DateTime fecha_pago { get; set; }
        public int dias_trabajados { get; set; }
        public string nombre_mes { get; set; }
        public decimal sueldo_bruto { get; set; }
        public decimal sueldo_neto { get; set; }
        public bool activo { get; set; }

        // Constructor por defecto
        public Modelo_Nomina()
        {
        }
    }

}
