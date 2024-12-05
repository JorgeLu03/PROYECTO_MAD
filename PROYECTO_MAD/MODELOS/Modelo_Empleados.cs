using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROYECTO_MAD.MODELOS
{
    public class Modelo_Empleados
    {
        public int id_empleado { get; set; }
        public int id_empresa { get; set; }
        public int id_departamento { get; set; }
        public int id_puesto { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string curp { get; set; }
        public string nss { get; set; }
        public string rfc { get; set; }
        public string domicilio { get; set; }
        public string banco { get; set; }
        public string numero_cuenta { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_contratacion { get; set; }
        public bool activo { get; set; }

        public Modelo_Empleados()
        {
            fecha_contratacion = DateTime.Now;
            fecha_nacimiento = DateTime.Now;
        }

        public Modelo_Empleados(int id_empleado, int id_empresa, int id_departamento, int id_puesto, string usuario, string contrasena, string nombre, string apellido_paterno, string apellido_materno, DateTime fecha_nacimiento, string curp, string nss, string rfc, string domicilio, string banco, string numero_cuenta, string email, string telefono, DateTime fecha_contratacion, bool activo)
        {
            this.id_empleado = id_empleado;
            this.id_empresa = id_empresa;
            this.id_departamento = id_departamento;
            this.id_puesto = id_puesto;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.fecha_nacimiento = fecha_nacimiento;
            this.curp = curp;
            this.nss = nss;
            this.rfc = rfc;
            this.domicilio = domicilio;
            this.banco = banco;
            this.numero_cuenta = numero_cuenta;
            this.email = email;
            this.telefono = telefono;
            this.fecha_contratacion = fecha_contratacion;
            this.activo = activo;
        }
    }
}
