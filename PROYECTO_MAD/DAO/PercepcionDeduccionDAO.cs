using Aspose.Pdf.Forms;
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
    public class PercepcionDeduccionDAO
    {
        public static List<Modelo_Percepcion> sp_get_percepciones(string buscar)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Percepcion>(
                "SP_GET_PERCEPCIONES",
                new
                {
                    @Buscar = buscar,
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }

        public static List<Modelo_Deduccion> sp_get_deducciones(string buscar)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Deduccion>(
                "SP_GET_DEDUCCIONES",
                new
                {
                    @Buscar = buscar,
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }

        public static void sp_gestion_percepcion(Modelo_Percepcion percepcion, string OPC)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Percepcion>("SP_GESTION_PERCEPCION",
                new
                {
                    @opcion = OPC,
                    @id_percepcion = percepcion.id_percepcion,
                    @nombre_percepcion = percepcion.nombre_percepcion,
                    @es_porcentaje = percepcion.es_porcentaje,
                    @monto = percepcion.monto,
                    @activo = percepcion.activo
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }

        public static void sp_gestion_deduccion(Modelo_Deduccion deduccion, string OPC)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Deduccion>("SP_GESTION_DEDUCCION",
                new
                {
                    @opcion = OPC,
                    id_deduccion = deduccion.id_deduccion,
                    nombre_deduccion = deduccion.nombre_deduccion,
                    @es_porcentaje = deduccion.es_porcentaje,
                    @monto = deduccion.monto,
                    @activo = deduccion.activo
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }

        public static List<Modelo_Mes> sp_get_meses_percepcion(int id_percepcion)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Mes>("SP_GET_MESES_PERCEPCION",
                new
                {
                    @id_percepcion = id_percepcion,
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }

        public static List<Modelo_Mes> sp_get_meses_deduccion(int id_deduccion)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Mes>("SP_GET_MESES_DEDUCCION",
                new
                {
                    @id_deduccion = id_deduccion,
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }

        public static List<Modelo_Mes> sp_get_meses()
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Mes>("SP_GET_MESES",
                new
                {
                    
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }

        public static void sp_gestion_pdm(string OPC, Modelo_Mes model)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Mes>("SP_GESTION_PDM",
                new
                {
                    @opcion = OPC,
                    @id_percepcion = model.id_percepcion,
                    @id_deduccion = model.id_deduccion,
                    @nombre_mes = model.nombre_mes,
                    @activo = model.activo
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }

        public static void sp_gestion_nomina(string OPC, Modelo_Nomina model)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Mes>("SP_GESTION_NOMINA",
                new
                {
                    @opcion = OPC,
                    @id_nomina = model.id_nomina,
                    @id_empleado = model.id_empleado,
                    @fecha_pago = model.fecha_pago,
                    @nombre_mes = model.nombre_mes,
                    @sueldo_bruto = model.sueldo_bruto,
                    @sueldo_neto = model.sueldo_neto,
                    @activo = model.activo
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }

        public static List<Modelo_Nomina> sp_get_nomina_empleado(int id_empleado)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Nomina>("SP_GET_NOMINAS_EMPLEADO",
                new
                {
                    //@id_empleado = id_empleado
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data.ToList();
        }
    }
}
