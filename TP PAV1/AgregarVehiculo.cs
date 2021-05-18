using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV1.AD;
using TP_PAV1.Entidades;

namespace TP_PAV1
{
    public partial class AgregarVehiculo : Form
    {
        public AgregarVehiculo()
        {
            InitializeComponent();
            
        }
        Vehiculo ClaseVehiculo = new Vehiculo();
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarVehiculo_Load(object sender, EventArgs e)
        {
            CargarCombosTipoDocumento();
            CargarCombosMarcas();
            CargarCombosTipoVehiculo();
        }

        private void CargarCombosTipoDocumento()
        {
            try
            {
                cmbTipoDoc.DataSource = AD_Varios.ObtenerTiposDeDocumentos();
                cmbTipoDoc.DisplayMember = "nombre_tipo_documento";
                cmbTipoDoc.ValueMember = "id_tipo_documento";
                cmbTipoDoc.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar combo tipo de documento");
            }
        }

        private void CargarCombosMarcas()
        {
            try
            {
                cmbMarca.DataSource = AD_Varios.ObtenerMarcas();
                cmbMarca.DisplayMember = "nombre_modelo_automovil";
                cmbMarca.ValueMember = "id_modelo_automovil";
                cmbMarca.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar combo marcas");
            }
        }

        private void CargarCombosTipoVehiculo()
        {
            try
            {
                cmbTipo.DataSource = AD_Varios.obtenerTipos();
                cmbTipo.DisplayMember = "nombre_tipo"; 
                cmbTipo.ValueMember = "id_tipo_vehiculo";
                cmbTipo.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar combo tipo de Vehiculo");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPatenteNueva.Equals("") || cmbMarca.Text.Equals("") || txtNroDoc.Equals("") || cmbTipoDoc.Equals("") || cmbTipo.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos!");
            }
            else
            {
                string patenteVehiculo = txtPatenteNueva.Text;
                int modeloVehiculo = (int)cmbMarca.SelectedValue;
                string nroDocVehiculo = txtNroDoc.Text;
                int tipoDocVehiculo = (int)cmbTipoDoc.SelectedValue;
                int tipoVehiculo = (int)cmbTipo.SelectedValue;

                bool resultado = AD_Vehiculo.InsertarVehiculo(patenteVehiculo,tipoDocVehiculo,nroDocVehiculo,modeloVehiculo,tipoVehiculo);
                if (resultado)
                {
                    MessageBox.Show("Vehiculo Nuevo Agregado con Exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar nuevo usuario");
                }
            }
            
        }
    }
}
