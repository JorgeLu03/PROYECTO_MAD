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
    public class DepartamentosDAO
    {
        public static List<Modelo_Departamentos> get_departamentos()
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Departamentos>("SELECT ID_Departamento,Nombre FROM DEPARTAMENTO");
            Conexion.Disconnect();
            return data.ToList();
        }

        public static Modelo_Departamentos sp_get_departamento(int Dpto)
        {
            Conexion.Connect();

            var data = Conexion.db.QueryFirstOrDefault<Modelo_Departamentos>(
                "SP_GET_DEPARTAMENTO",
                new
                {
                    @DepartamentoID = Dpto,

                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data;
        }

        public static List<Modelo_Departamentos> sp_get_departamento2(string Dpto)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Departamentos>(
                "SP_GET_DEPATRTAMENTO2",
                new
                {
                    @Buscar = Dpto,

                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }

        public static void sp_gestion_departamento(Modelo_Departamentos dpto, string OPC)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Departamentos>("SP_GESTION_DEPARTAMENTO",
                new
                {
                    @ID_Departamento = dpto.ID_Departamento,
                    @Nombre = dpto.Nombre,
                    @SueldoBase = dpto.SueldoBase,
                    @OPC = OPC
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }
    }
}
