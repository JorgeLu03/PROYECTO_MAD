using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.Entidad
{
    public class Usuario
    {

        public int id { get; set; }
        public string correoElectronico { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int genero { get; set; }

        public Usuario() { }

        public Usuario(int id, string correoElectronico, string contrasena, string nombre, DateTime fechaNacimiento, int genero)
        {
            this.id = id;
            this.correoElectronico = correoElectronico;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
        }
    }
}
