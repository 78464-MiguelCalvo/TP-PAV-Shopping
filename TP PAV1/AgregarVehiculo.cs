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

namespace TP_PAV1
{
    public partial class AgregarVehiculo : Form
    {
        public AgregarVehiculo()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarVehiculo_Load(object sender, EventArgs e)
        {
            CargarCombosTipoDocumento();
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
                MessageBox.Show("Error al cargar combo tipo de docoento");
            }
        }
    }
}
