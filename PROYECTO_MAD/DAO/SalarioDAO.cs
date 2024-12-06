using Dapper;
using PROYECTO_MAD.CONEXIÓN;
using PROYECTO_MAD.Entidad;
using PROYECTO_MAD.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_MAD.DAO
{
    public class SalarioDAO
    {
        public static Modelo_Salario sp_get_salario_bruto(int dias, int id_empleado)
        {
            Conexion.Connect();

            var data = Conexion.db.QueryFirstOrDefault<Modelo_Salario>(
                "SP_GET_SALARIO_BRUTO",
                new
                {
                    @dias=dias,
                    @id_empleado=id_empleado

                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data;
        }

    }

}
