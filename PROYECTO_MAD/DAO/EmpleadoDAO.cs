using Dapper;
using PROYECTO_MAD.CONEXIÓN;
using PROYECTO_MAD.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.DAO
{
    public class EmpleadoDAO
    {
        public static void sp_gestion_empleado(Modelo_Empleados empleado, string OPC)
        {
            Conexion.Connect();

            //var data = Conexion.db.Query<Modelo_Empleados>("SP_GESTION_EMPLEADO",
            //    new
            //    {
            //        @Num_Empleado = empleado.Num_Empleado,
            //        @Nombre_Completo = empleado.Nombre_Completo,
            //        @Fecha_Nac = empleado.Fecha_Nac,
            //        @CURP = empleado.CURP,
            //        @Email = empleado.Email,
            //        @ApellidoMaterno = empleado.ApellidoMaterno,
            //        @ApellidoPaterno = empleado.ApellidoPaterno,
            //        @NSS = empleado.NSS,
            //        @RFC = empleado.RFC,
            //        @Telefono = empleado.Telefono,
            //        @Contraseña = empleado.Contraseña,
            //        @DomicilioCompleto = empleado.DomicilioCompleto,
            //        @Banco = empleado.Banco,
            //        @FechaIngreso = empleado.FechaIngreso,
            //        @PuestoID = empleado.PuestoID,
            //        @DepartamentoID = empleado.DepartamentoID,
            //        @NumeroCuenta = empleado.NumeroCuenta,
            //        @OPC = OPC
            //    },
            //    commandType: CommandType.StoredProcedure);

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
