using System.Data;
using System.Data.SqlClient;

namespace Ventas.ADO.NET
{
    public class UsuarioHandler : DbHandler
    {
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM Usuario", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        // Me aseguro que haya filas que leer
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Usuario usuario = new Usuario();

                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.Contraseña = dataReader["Contraseña"].ToString();
                                usuario.Mail = dataReader["Mail"].ToString();
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }

            return usuarios;
        }

        public string Login(string Usuario, string Clave)
        {
            string resultado = "";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM Usuario where NombreUsuario = '" + Usuario + "' and Contraseña = '" + Clave + "'", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        // Me aseguro que haya filas que leer
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                if (Usuario == dataReader["NombreUsuario"].ToString() && Clave == dataReader["Contraseña"].ToString())
                                {
                                    resultado = "OK";
                                }
                                else
                                {
                                    resultado = "Error";
                                }

                            }

                        }

                    }

                }
            }
            return resultado;
        }
    }
}
