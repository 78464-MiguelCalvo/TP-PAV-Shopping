using Microsoft.Reporting.WinForms;
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
    public partial class FormListados : Form
    {
        public FormListados()
        {
            InitializeComponent();
        }
                    
        private void FormListados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosTarjetasClientes.ListadoTarjetasPorCliente' Puede moverla o quitarla según sea necesario.
            this.ListadoTarjetasPorClienteTableAdapter.Fill(this.DatosTarjetasClientes.ListadoTarjetasPorCliente);
            // TODO: esta línea de código carga datos en la tabla 'TablasTPShopping.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.TablasTPShopping.clientes);

            // TODO: esta línea de código carga datos en la tabla 'LocalesXTipoComercio.LocalesXTipoComercio' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ArticuloXRubro.ObtenerArticuloXRubro();
            ReportDataSource ds = new ReportDataSource("ArticulosXRubro", tabla);

            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.DataSources.Add(ds);
            reportViewer3.LocalReport.Refresh();
        }

        private void reportViewer4_Load_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ArticuloXLocal.ObtenerArticuloXLocal();
            ReportDataSource ds = new ReportDataSource("ArticulosXLocal", tabla);

            reportViewer4.LocalReport.DataSources.Clear();
            reportViewer4.LocalReport.DataSources.Add(ds);
            reportViewer4.LocalReport.Refresh();
        }

        private void reportViewer5_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Cliente.ObtenerListadoDeClientes();

            ReportDataSource ds = new ReportDataSource("DatosClientes", tabla);
            reportViewer5.LocalReport.DataSources.Clear();
            reportViewer5.LocalReport.DataSources.Add(ds);
            reportViewer5.LocalReport.Refresh();

        }

        private void reportViewer6_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Varios.ObtenerListadoDeTarjetasPorCliente();

            ReportDataSource ds = new ReportDataSource("DatosTarjetasClientes", tabla);
            reportViewer5.LocalReport.DataSources.Clear();
            reportViewer5.LocalReport.DataSources.Add(ds);
            reportViewer5.LocalReport.Refresh();
        }
    }
}
