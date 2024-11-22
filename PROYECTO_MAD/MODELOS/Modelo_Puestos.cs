using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_Puestos
    {
        // Propiedades
        public int ID_Puesto { get; set; }
        public string Nombre { get; set; }
        public decimal NivelSalarial { get; set; }
        public int ID_Departamento { get; set; }

        // Constructor por defecto
        public Modelo_Puestos()
        {
        }

        // Constructor con parámetros
        public Modelo_Puestos(int id_Puesto, string nombre, decimal nivelSalarial, int id_Departamento)
        {
            ID_Puesto = id_Puesto;
            Nombre = nombre;
            NivelSalarial = nivelSalarial;
            ID_Departamento = id_Departamento;
        }
    }

}
