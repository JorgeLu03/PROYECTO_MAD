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
    public class UsuarioDAO
    {

        public static int InsertarUsuario(Usuario usuario) {
            int retorno = 0;

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC InsertarUsuario @correo_electronico = '" + usuario.correoElectronico + "', @contraseña = '" + usuario.contrasena + "', @nombre = '" + usuario.nombre + "', @fecha_nacimiento = '" + usuario.fechaNacimiento.Date.ToString("yyyy-MM-dd") + "', @genero = " + usuario.genero + "; ";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorno = comando.ExecuteNonQuery();
            }

            return retorno;
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT * FROM USUARIOS;";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.id = reader.GetInt32(0);
                    usuario.correoElectronico = reader.GetString(1);
                    usuario.contrasena = reader.GetString(2);
                    usuario.nombre = reader.GetString(3);
                    usuario.fechaNacimiento = reader.GetDateTime(4);
                    usuario.genero = reader.GetInt32(5);

                    lista.Add(usuario);

                }
                return lista;

            }

        }

        public static List<Usuario> ObtenerUsuarios(int usuarioId)
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "SELECT * FROM USUARIOS WHERE id = " + usuarioId.ToString() +";";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.id = reader.GetInt32(0);
                    usuario.correoElectronico = reader.GetString(1);
                    usuario.contrasena = reader.GetString(2);
                    usuario.nombre = reader.GetString(3);
                    usuario.fechaNacimiento = reader.GetDateTime(4);
                    usuario.genero = reader.GetInt32(5);

                    lista.Add(usuario);

                }
                return lista;

            }

        }

        public static void BorrarUsuario(int usuarioId)
        {
          
            using (SqlConnection conexion = BDConexion.ObtenerConexion())
            {
                string query = "EXEC BorrarUsuario @idP = " + usuarioId + "; ";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.ExecuteNonQuery();
            }

        }

        


    }
}
