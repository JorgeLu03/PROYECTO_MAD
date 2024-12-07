using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_Mes
    {
        public int id_percepcion { get; set; }
        public int id_deduccion { get; set; }
        public int numero_mes { get; set; }
        public int dias_mes { get; set; }
        public string nombre_mes { get; set; }
        public bool activo { get; set; }
    }
}
