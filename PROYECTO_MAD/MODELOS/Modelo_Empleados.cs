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
        public int Num_Empleado { get; set; }
        public string Nombre_Completo { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string CURP { get; set; }
        public string Email { get; set; }
        public string NSS { get; set; }
        public string RFC { get; set; }
        public string Telefono { get; set; }
        public string Contraseña { get; set; }
        public string DomicilioCompleto { get; set; }
        public string Banco { get; set; }
        public string NumeroCuenta { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int PuestoID { get; set; }
        public int DepartamentoID { get; set; }

        public Modelo_Empleados()
        {
            FechaIngreso = DateTime.Now;
            Fecha_Nac = DateTime.Now;
        }
        // Constructor completo
        public Modelo_Empleados(int num_Empleado, string nombre_Completo, string apellidoPaterno, string apellidoMaterno,
                                 DateTime fecha_Nac, string cURP, string email, string nSS, string rFC,
                                 string telefono, string contraseña, string domicilioCompleto, string banco,
                                 string numeroCuenta, DateTime fechaIngreso, int puestoID, int departamentoID)
        {
            Num_Empleado = num_Empleado;
            Nombre_Completo = nombre_Completo;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Fecha_Nac = fecha_Nac;
            CURP = cURP;
            Email = email;
            NSS = nSS;
            RFC = rFC;
            Telefono = telefono;
            Contraseña = contraseña;
            DomicilioCompleto = domicilioCompleto;
            Banco = banco;
            NumeroCuenta = numeroCuenta;
            FechaIngreso = fechaIngreso;
            PuestoID = puestoID;
            DepartamentoID = departamentoID;
        }
    }
}
