using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_Deduccion
    {
        public int id_deduccion { get; set; }
        public string nombre_deduccion { get; set; }
        public bool es_porcentaje { get; set; }
        public decimal monto { get; set; }
        public bool activo { get; set; }
        public Modelo_Deduccion()
        {
        }

        // Constructor con parámetros
        public Modelo_Deduccion(int id_deduccion, string nombre_deduccion, bool es_porcentaje, decimal monto, bool activo)
        {
            this.id_deduccion = id_deduccion;
            this.nombre_deduccion = nombre_deduccion;
            this.es_porcentaje = es_porcentaje;
            this.monto = monto;
            this.activo = activo;
        }

    }

}
