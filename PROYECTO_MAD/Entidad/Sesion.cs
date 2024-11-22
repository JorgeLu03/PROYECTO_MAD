using PROYECTO_MAD.MODELOS;
using PROYECTO_MAD.PANTALLAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Sesion
    {
        public static Modelo_Empleados empleado { get; set; }
        public static Modelo_Departamentos departamentos { get; set; }
        public static Modelo_Puestos puesto { get; set; }
    }
}
