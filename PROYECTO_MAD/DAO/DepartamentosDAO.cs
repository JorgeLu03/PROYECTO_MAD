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
    }
}
