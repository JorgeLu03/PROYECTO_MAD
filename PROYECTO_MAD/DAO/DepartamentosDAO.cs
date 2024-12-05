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
    public class DepartamentosDAO
    {
        public static List<Modelo_Departamentos> get_departamentos()
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Departamentos>("SELECT ID_Departamento,Nombre FROM DEPARTAMENTO");
            Conexion.Disconnect();
            return data.ToList();
        }

        public static Modelo_Departamentos sp_get_departamento_login(int id_departamento)
        {
            Conexion.Connect();

            var data = Conexion.db.QueryFirstOrDefault<Modelo_Departamentos>(
                "SP_GET_DEPARTAMENTO_LOGIN",
                new
                {
                    @id_departamento = id_departamento,

                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();

            return data;
        }

        public static List<Modelo_Departamentos> sp_get_departamentos(string buscar)
        {
            Conexion.Connect();

            var data = Conexion.db.Query<Modelo_Departamentos>(
                "SP_GET_DEPARTAMENTOS",
                new
                {
                    @buscar = buscar,

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
                    @opcion = OPC,
                    @id_departamento = dpto.id_departamento,
                    @id_empresa = dpto.id_empresa,
                    @nombre_departamento = dpto.nombre_departamento,
                    @sueldo_base_diario = dpto.sueldo_base_diario,
                    @activo = dpto.activo
                },
                commandType: CommandType.StoredProcedure);

            Conexion.Disconnect();
        }
    }
}
