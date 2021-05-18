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
    public partial class FormVehiculos : Form
    {
       
        public FormVehiculos()
        {
            InitializeComponent();
            
        }
        private void FormVehiculos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
           
        }
        Vehiculo ClaseVehiculo = new Vehiculo();

        private void PICAgregarVehuciulo_Click(object sender, EventArgs e)
        {
            AgregarVehiculo VentanaAgregarVehiculo = new AgregarVehiculo();
            VentanaAgregarVehiculo.Show();
        }

        private void PICEliminarVehiculo_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que deseas borrar el Vehiculo?" + ClaseVehiculo.patenteVehiculo, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == r)
            {
                AD_Vehiculo.EliminarVehiculo(ClaseVehiculo.patenteVehiculo);
            }
        }

        private void cargarGrilla()
        {
            GrillaVehiculos.DataSource = AD_Vehiculo.obtenerVehiculos();
        }

        private void GrillaVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = GrillaVehiculos.Rows[indice];
            string patente = filaSeleccionada.Cells["patente"].Value.ToString();
            ClaseVehiculo = AD_Vehiculo.obtenerVehiculoPorPatente(patente);
        }

        private void PICActualizarGrilla_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void PICModificarVehiculo_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que deseas Modificar el vehiculo " + ClaseVehiculo.patenteVehiculo , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == r)
            {
                MessageBox.Show("en esa");
            }
        }
    }
}
