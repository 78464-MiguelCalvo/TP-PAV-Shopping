using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV1.AD
{
    class AD_PlayasYEstacionamientos
    {
        public static DataTable ObtenerEstacionamientosPorPlaya(int idPlaya)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "BuscarEstacionamientosPorPlaya";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPlaya", idPlaya);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }



        public static DataTable ObtenerPlayas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetPlayas";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public static bool InsertarEstacionamiento(Estacionamiento e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool res = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertTarjeta";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idPlaya", e.IdPlaya);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return res;
        }
    }



}
