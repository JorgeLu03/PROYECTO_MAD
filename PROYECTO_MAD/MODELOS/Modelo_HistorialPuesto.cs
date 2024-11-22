using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_HistorialPuesto
    {
        // Propiedades
        public int ID_Historial { get; set; }
        public int ID_Empleado { get; set; }
        public int ID_Puesto_Nuevo { get; set; }
        public int ID_Puesto_Viejo { get; set; }
        public DateTime FechaCambio { get; set; }

        // Constructor por defecto
        public Modelo_HistorialPuesto()
        {
        }

        // Constructor con parámetros
        public Modelo_HistorialPuesto(int id_Historial, int id_Empleado, int id_Puesto_Nuevo, int id_Puesto_Viejo, DateTime fechaCambio)
        {
            ID_Historial = id_Historial;
            ID_Empleado = id_Empleado;
            ID_Puesto_Nuevo = id_Puesto_Nuevo;
            ID_Puesto_Viejo = id_Puesto_Viejo;
            FechaCambio = fechaCambio;
        }
    }

}
