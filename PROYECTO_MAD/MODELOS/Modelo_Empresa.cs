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
        public string RAZSOC { get; set; }
        public string DOMFISC { get; set; }
        public string CONTACT { get; set; }
        public DateTime INICOP { get; set; }
        public int REGPAT { get; set; }

        // Constructor por defecto
        public Modelo_Empresa()
        {
        }

        // Constructor con parámetros
        public Modelo_Empresa(int id_Empresa, string rfc, string razsoc, string domfisc, string contact, DateTime inicop, int regpat)
        {
            ID_Empresa = id_Empresa;
            RFC = rfc;
            RAZSOC = razsoc;
            DOMFISC = domfisc;
            CONTACT = contact;
            INICOP = inicop;
            REGPAT = regpat;
        }
    }

}
