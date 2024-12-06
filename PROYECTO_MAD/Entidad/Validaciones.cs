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

namespace PROYECTO_MAD.Entidad
{
    static class Validaciones
    {
        public static bool ValidarBlanco(string text)
        {
            return !string.IsNullOrEmpty(text);
        }
        public static bool ValidarNumero(string text)
        {
            return int.TryParse(text, out _);
        }
        public static bool EsTexto(string texto)
        {
            return texto.All(char.IsLetter);
        }

    }
}
