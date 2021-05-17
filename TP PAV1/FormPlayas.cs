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
    public partial class FormPlayas : Form
    {
        public FormPlayas()
        {
            InitializeComponent();
        }

        // metodos para limpiar campos del form
        private void LimpiarCamposPnlEstacionamientos()
        {
            txtNroEstacionamiento.Text = "";
            cmbPlaya.SelectedValue = -1;
            //VER COMBOBOX. selecteditem? selectedvalue?
        }

        private void LimpiarCamposPnlPlayas()
        {
            txtPlaya.Text = "";
            txtIDPlaya.Text = "";
        }

        private void FormPlayas_Load(object sender, EventArgs e)
        {
            LimpiarCamposPnlEstacionamientos();
            LimpiarCamposPnlPlayas();
            CargarGrillaEstacionamientos();
        }

        private void btnNuevoEstacionamiento_Click(object sender, EventArgs e)
        {
            TomarDatosEstacionamiento();
        }

        private void TomarDatosEstacionamiento()
        {

        }

        private void CargarGrillaEstacionamientos()
        {
            try
            {
                dgvEstacionamientos.DataSource = AD_PlayasYEstacionamientos.ObtenerEstacionamientosPorPlaya();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener estacionamientos");
            }

        }
    }
}
