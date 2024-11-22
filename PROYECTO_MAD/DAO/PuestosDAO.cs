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
    }
}
