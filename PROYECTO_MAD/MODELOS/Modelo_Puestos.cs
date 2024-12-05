using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_Puestos
    {
        public int id_puesto { get; set; }
        public int id_departamento { get; set; }
        public string nombre_puesto { get; set; }
        public decimal proporcion_sueldo { get; set; }
        public bool activo { get; set; }

        // Constructor por defecto
        public Modelo_Puestos()
        {
        }

        // Constructor con parámetros
        public Modelo_Puestos(int id_puesto, int id_departamento, string nombre_puesto, decimal proporcion_sueldo, bool activo)
        {
            this.id_puesto = id_puesto;
            this.id_departamento = id_departamento;
            this.nombre_puesto = nombre_puesto;
            this.proporcion_sueldo = proporcion_sueldo;
            this.activo = activo;
        }

    }

}
