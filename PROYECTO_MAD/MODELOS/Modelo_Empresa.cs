using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.MODELOS
{
    internal class Modelo_Empresa
    {
        // Propiedades
        public int ID_Empresa { get; set; }
        public string RFC { get; set; }

        // Constructor por defecto
        public Modelo_Empresa()
        {
        }

        // Constructor con parámetros
        public Modelo_Empresa(int id_Empresa, string rfc)
        {
            ID_Empresa = id_Empresa;
            RFC = rfc;
        }
    }

}
