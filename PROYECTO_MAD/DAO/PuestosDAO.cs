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
        public static Modelo_Puestos sp_get_puestoEmpleado(int PUESTO)
        {
            Conexion.Connect();

            var data = Conexion.db.QueryFirstOrDefault<Modelo_Puestos>(
                "SP_GET_PUESTOEMPLEADO",
                new
                {
                    @Puesto = PUESTO,

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
                    @ID_Puesto = puesto.ID_Puesto,
                    @Nombre = puesto.Nombre,
                    @NivelSalarial = puesto.NivelSalarial,
                    @ID_Departamento = puesto.ID_Departamento,
                    @OPC = OPC
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }
    }
}
