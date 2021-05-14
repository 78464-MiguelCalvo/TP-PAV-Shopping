using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.AD
{
    public class AD_usuario
    {
        public static bool ValidarUsuario(string nombre, string contraseña)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM usuarios WHERE usuario like @nombreUsu AND contraseña like @pass";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", nombre);
                cmd.Parameters.AddWithValue("@pass", contraseña);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }

    }
}
