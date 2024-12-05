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
        public int id_departamento { get; set; }
        public int id_empresa { get; set; }
        public string nombre_departamento { get; set; }
        public decimal sueldo_base_diario { get; set; }
        public bool activo { get; set; }

        // Constructor por defecto
        public Modelo_Departamentos()
        {
        }

        public Modelo_Departamentos(int id_departamento, int id_empresa, string nombre_departamento, decimal sueldo_base_diario, bool activo)
        {
            this.id_departamento = id_departamento;
            this.id_empresa = id_empresa;
            this.nombre_departamento = nombre_departamento;
            this.sueldo_base_diario = sueldo_base_diario;
            this.activo = activo;
        }
    }

}
