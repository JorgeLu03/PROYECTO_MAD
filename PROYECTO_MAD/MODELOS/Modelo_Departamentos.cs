using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_Departamentos
    {
        // Propiedades
        public int ID_Departamento { get; set; }
        public string Nombre { get; set; }
        public decimal SueldoBase { get; set; }

        // Constructor por defecto
        public Modelo_Departamentos()
        {
        }

        // Constructor con parámetros
        public Modelo_Departamentos(int id_Departamento, string nombre, decimal sueldoBase)
        {
            ID_Departamento = id_Departamento;
            Nombre = nombre;
            SueldoBase = sueldoBase;
        }
    }

}
