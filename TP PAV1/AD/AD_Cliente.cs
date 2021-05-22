﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV1.Entidades;

namespace TP_PAV1.AD
{
    public class AD_Cliente
    {
        public static DataTable ObtenerTabla(string nombreTabla)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM "+nombreTabla;

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
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

        public static DataTable ObtenerListadoClientesReducido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT apellido, nombre, tipo_documento, nro_documento FROM clientes";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
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

        public static bool ActualizarCliente(Cliente cli)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, calle = @calle, calle_nro = @calle_nro, id_barrio = @id_barrio, fecha_Nacimiento = @fechaNacimiento,  id_sexo = @idSexo,  id_estado_civil = @id_estado_civil WHERE tipo_documento = @tipo_documento AND nro_documento = @nroDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_documento", cli.TipoDocumentoCliente);
                cmd.Parameters.AddWithValue("@nroDocumento", cli.DocumentoCliente);
                cmd.Parameters.AddWithValue("@nombre", cli.NombreCliente.ToString());
                cmd.Parameters.AddWithValue("@apellido", cli.ApellidoCliente);
                cmd.Parameters.AddWithValue("@calle", cli.CalleCliente);
                cmd.Parameters.AddWithValue("@calle_nro", cli.NroCasaCliente.ToString());
                cmd.Parameters.AddWithValue("@id_barrio", cli.BarrioCliente);
                cmd.Parameters.AddWithValue("@fechaNacimiento", cli.FechaNacimientoCliente);
                cmd.Parameters.AddWithValue("@idSexo", cli.SexoCliente);
                cmd.Parameters.AddWithValue("@id_estado_civil", cli.EstadoCivilCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        public static bool EliminarCliente(Cliente cli)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaTP1"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM clientes WHERE tipo_documento = @tipo_documento AND nro_documento = @nroDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_documento", cli.TipoDocumentoCliente);
                cmd.Parameters.AddWithValue("@nroDocumento", cli.DocumentoCliente);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
    
    }
}
