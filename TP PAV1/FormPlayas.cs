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
        bool banderaCmb = false;

        public FormPlayas()
        {
            InitializeComponent();
        }

        // metodos para limpiar campos del form
        private void LimpiarCamposPnlEstacionamientos()
        {
            cmbPlaya.SelectedIndex = -1;
        }

        private void LimpiarCamposPnlPlayas()
        {
            txtPlaya.Text = "";
        }

        private void FormPlayas_Load(object sender, EventArgs e)
        {
            LimpiarCamposPnlEstacionamientos();
            LimpiarCamposPnlPlayas();
            CargarComboPlaya();
        }

        private void btnNuevoEstacionamiento_Click(object sender, EventArgs e)
        {
            
            Estacionamiento est = TomarDatosEstacionamiento();
            bool resp = AD_PlayasYEstacionamientos.InsertarEstacionamiento(est);
            if (resp)
            {
                MessageBox.Show("El estacionamiento se ingreso correctamente");
                LimpiarCamposPnlEstacionamientos();
            }
            else
            {
                MessageBox.Show("Hubo un error al insertar el estacionamiento");
            }
        }


        private Estacionamiento TomarDatosEstacionamiento()
        {
            int idPlaya = Convert.ToInt32(cmbPlaya.SelectedValue);
            Estacionamiento estacionamiento = new Estacionamiento();
            estacionamiento.IdPlaya = idPlaya;
            return estacionamiento;
        }

        private void CargarGrillaEstacionamientos(int idPlaya)
        {
            try
            {
                dgvEstacionamientos.DataSource = AD_PlayasYEstacionamientos.ObtenerEstacionamientosPorPlaya(idPlaya);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener estacionamientos");
            }

        }

        private void CargarComboPlaya()
        {
            try
            {
                cmbPlaya.DataSource = AD_PlayasYEstacionamientos.ObtenerPlayas();
                cmbPlaya.DisplayMember = "nombre_playa";
                cmbPlaya.ValueMember = "id_playa";
                cmbPlaya.SelectedIndex = -1;
                banderaCmb = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar el combo");
            } 
        }


        private void cmbPlaya_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Convert.ToString(cmbPlaya.SelectedValue) != "") && (banderaCmb))
            {
                CargarGrillaEstacionamientos(Convert.ToInt32(cmbPlaya.SelectedValue));
            }
        }




    }
}
