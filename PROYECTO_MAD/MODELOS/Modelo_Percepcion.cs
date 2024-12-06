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
        public int id_percepcion { get; set; }
        public string nombre_percepcion { get; set; }
        public bool es_porcentaje { get; set; }
        public decimal monto { get; set; }
        public bool activo { get; set; }

        // Constructor por defecto
        public Modelo_Percepcion()
        {
        }


        // Constructor con parámetros
        public Modelo_Percepcion(int id_percepcion, string nombre_percepcion, bool es_porcentaje, decimal monto, bool activo)
        {
            this.id_percepcion = id_percepcion;
            this.nombre_percepcion = nombre_percepcion;
            this.es_porcentaje = es_porcentaje;
            this.monto = monto;
            this.activo = activo;
        }

    }

}
