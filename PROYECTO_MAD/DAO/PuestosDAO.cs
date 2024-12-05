using Dapper;
using PROYECTO_MAD.CONEXIÓN;
using PROYECTO_MAD.MODELOS;
using PROYECTO_MAD.PANTALLAS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.DAO
{
    public class PuestosDAO
    {
        public static List<Modelo_Puestos> get_puestos()
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Puestos>("SELECT ID_Puesto,Nombre FROM PUESTO");
            Conexion.Disconnect();
            return data.ToList();
        }

        public static List<Modelo_Puestos> sp_get_puestos(string Puesto)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Puestos>(
                "SP_GET_PUESTOS",
                new
                {
                    @Buscar = Puesto,
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }

        public static Modelo_Puestos sp_get_puesto_login(int id_puesto)
        {
            Conexion.Connect();

            var data = Conexion.db.QueryFirstOrDefault<Modelo_Puestos>(
                "SP_GET_PUESTO_LOGIN",
                new
                {
                    @id_puesto = id_puesto,

                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data;
        }

        public static List<Modelo_Puestos> sp_get_puestoEmpleado2(string Puesto)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Puestos>(
                "SP_GET_PUESTOEMPLEADO2",
                new
                {
                    @Buscar = Puesto,

                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }

        public static void sp_gestion_puesto(Modelo_Puestos puesto, string OPC)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Puestos>("SP_GESTION_PUESTO",
                new
                {
                    @opcion = OPC,
                    @id_puesto = puesto.id_puesto,
                    @id_departamento = puesto.id_departamento,
                    @nombre_puesto = puesto.nombre_puesto,
                    @proporcion_sueldo = puesto.proporcion_sueldo,
                    @activo = puesto.activo,
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }
    }
}
