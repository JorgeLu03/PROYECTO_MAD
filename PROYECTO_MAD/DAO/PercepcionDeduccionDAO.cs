﻿using Dapper;
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
    }
}
