using Dapper;
using PROYECTO_MAD.CONEXIÓN;
using PROYECTO_MAD.Entidad;
using PROYECTO_MAD.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PROYECTO_MAD.DAO
{
    public class EmpleadoDAO
    {
        public static void sp_gestion_empleado(Modelo_Empleados empleado, string OPC)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Empleados>("SP_GESTION_EMPLEADO",
                new
                {
                    @opcion = OPC,
                    @id_empleado = empleado.id_empleado,
                    @id_empresa = empleado.id_empresa,
                    @id_departamento = empleado.id_departamento,
                    @id_puesto = empleado.id_puesto,
                    @usuario = empleado.usuario,
                    @contrasena = empleado.contrasena,
                    @nombre = empleado.nombre,
                    @apellido_paterno = empleado.apellido_paterno,
                    @apellido_materno = empleado.apellido_materno,
                    @fecha_nacimiento = empleado.fecha_nacimiento,
                    @curp = empleado.curp,
                    @nss = empleado.nss,
                    @rfc = empleado.rfc,
                    @domicilio = empleado.domicilio,
                    @banco = empleado.banco,
                    @numero_cuenta = empleado.numero_cuenta,
                    @email = empleado.email,
                    @telefono = empleado.telefono,
                    @fecha_contratacion = empleado.fecha_contratacion,
                    @activo = empleado.activo,
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }

        public static List<Modelo_Empleados> sp_get_empleado(string buscar)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Empleados>("SP_GET_EMPLEADOS",
                new
                {
                    @buscar = buscar
                },
                commandType: CommandType.StoredProcedure); ;

            Conexion.Disconnect();
            return data.ToList();
        }
        public static Modelo_Empleados sp_get_empleado_login(Modelo_Empleados emp)
        {
            Conexion.Connect();

            var data = Conexion.db.QueryFirstOrDefault<Modelo_Empleados>(
                "SP_GET_EMPLEADO_LOGIN",
                new
                {
                    @usuario = emp.usuario,
                    @contrasena = emp.contrasena,
                    @id_puesto = emp.id_puesto
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data;
        }
    }
}
