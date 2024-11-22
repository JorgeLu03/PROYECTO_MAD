using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_Percepcion
    {
        // Propiedades
        public int ID_Percepcion { get; set; }
        public int ID_Nomina { get; set; }
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        public bool EsPorcentaje { get; set; }

        // Constructor por defecto
        public Modelo_Percepcion()
        {
        }

        // Constructor con parámetros
        public Modelo_Percepcion(int id_Percepcion, int id_Nomina, string nombre, decimal monto, bool esPorcentaje)
        {
            ID_Percepcion = id_Percepcion;
            ID_Nomina = id_Nomina;
            Nombre = nombre;
            Monto = monto;
            EsPorcentaje = esPorcentaje;
        }
    }

}
