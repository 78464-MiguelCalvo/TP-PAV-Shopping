using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV1.Entidades;

namespace TP_PAV1.AD
{
    public class AD_Vehiculo
    {
        public static DataTable obtenerVehiculos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "getVehiculos";

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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static void EliminarVehiculo(String Patente)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Vehiculo v = new Vehiculo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EliminarVehiculo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Patente", Patente);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        public static Vehiculo obtenerVehiculoPorPatente(String patent)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Vehiculo veh = new Vehiculo();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "buscarVehiculoPorPatente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", patent);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    veh.patenteVehiculo= dr["patente"].ToString();
                    veh.tipoDocVehiculo = (int)dr["id_tipo_documento"];
                    veh.nroDocVehiculo = dr["nro_documento"].ToString();
                    veh.modeloVehiculo = (int)dr["id_marca_vehiculo"];
                    veh.tipoVehiculo = (int)dr["id_tipo_vehiculo"];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return veh;
        }

        public static bool InsertarVehiculo(string Patente, int idTipoDoc, string nroDoc,int idMarcaVehiculo,int idTipoVehiculo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevoVehiculo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@patente", Patente);
                cmd.Parameters.AddWithValue("@idTipoDoc", idTipoDoc);
                cmd.Parameters.AddWithValue("@nroDoc", nroDoc);
                cmd.Parameters.AddWithValue("@idMarcaVehiculo", idMarcaVehiculo);
                cmd.Parameters.AddWithValue("@idTipoVehiculo", idTipoVehiculo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return result;

        }
    }
}
