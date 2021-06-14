using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV1.AD
{
    public class AD_Ventas
    {
        public static bool altaNuevaCompra(int nroCompra,int nro_local, int tipo_documento, string nro_documento,DateTime Fecha,int Total, List<int> listaDeDetalles,int Cantidad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlTransaction objTranssacion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "InsertarCompra";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro_local", nro_local);
                cmd.Parameters.AddWithValue("@tipo_documento", tipo_documento);
                cmd.Parameters.AddWithValue("@nro_documento", nro_documento);
                cmd.Parameters.AddWithValue("@fecha_compra", Fecha);
                cmd.Parameters.AddWithValue("@monto", Total);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;


                cn.Open();

                objTranssacion = cn.BeginTransaction("AltaDeCompra");
                cmd.Transaction = objTranssacion;
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                foreach (var id_articulo in listaDeDetalles)
                {
                    string consultaCompraxDetalle = "insertDetalleCompra";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nro_compra", nroCompra);
                    cmd.Parameters.AddWithValue("@id_articulo", id_articulo);
                    cmd.Parameters.AddWithValue("@cantidad", Cantidad);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consultaCompraxDetalle;
                    cmd.ExecuteNonQuery();

                }
                objTranssacion.Commit();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                objTranssacion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }
        }


        public static DataTable obtenerListadoVentas()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "GetCompras";

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

        public static int ObtenerUltimaCompra()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT MAX(nro_compra) FROM compras";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();
                return resultado;

            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }


        public static DataTable obtenerVentasPorArticulo()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "VentasPorArticulo";

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

    }
}
