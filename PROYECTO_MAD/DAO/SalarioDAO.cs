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

        public static Modelo_Salario calcula_percepciones_deducciones(Modelo_Salario salario)
        {
            List<Modelo_Percepcion> percepciones = PercepcionDeduccionDAO.sp_get_percepciones(""); // cambiar a nueva logica
            List<Modelo_Deduccion> deducciones = PercepcionDeduccionDAO.sp_get_deducciones(""); // cambiar a nueva logica

            decimal percepcionesCalculadas = 0;
            decimal deduccionesCalculadas = 0;

            foreach (Modelo_Percepcion item in percepciones)
            {
                if (item.es_porcentaje == false)
                {
                    percepcionesCalculadas = percepcionesCalculadas + item.monto;
                }
                else
                {
                    decimal cantidadReal = item.monto * salario.Sueldo_Bruto_Mensual;
                    percepcionesCalculadas = percepcionesCalculadas + cantidadReal;
                }
            }

            foreach (Modelo_Deduccion item in deducciones)
            {
                if (item.es_porcentaje == false)
                {
                    deduccionesCalculadas = deduccionesCalculadas - item.monto;
                }
                else
                {
                    decimal cantidadReal = item.monto * salario.Sueldo_Bruto_Mensual;
                    deduccionesCalculadas = deduccionesCalculadas - cantidadReal;
                }
            }

            salario.Sueldo_Neto_Mensual = salario.Sueldo_Bruto_Mensual + percepcionesCalculadas - deduccionesCalculadas;
            salario.percepciones = percepcionesCalculadas;
            salario.deducciones = deduccionesCalculadas;

            return salario;
        }

    }

}
