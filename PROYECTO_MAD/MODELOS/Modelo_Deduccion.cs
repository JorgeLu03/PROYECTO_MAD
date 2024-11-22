using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_Deduccion
    {
        public int ID_Deduccion { get; set; }
        public int ID_Nomina { get; set; }
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        public bool EsPorcentaje { get; set; }

        public Modelo_Deduccion()
        {
        }

        // Constructor con parámetros
        public Modelo_Deduccion(int id_Deduccion, int id_Nomina, string nombre, decimal monto, bool esPorcentaje)
        {
            ID_Deduccion = id_Deduccion;
            ID_Nomina = id_Nomina;
            Nombre = nombre;
            Monto = monto;
            EsPorcentaje = esPorcentaje;
        }
    }

}
