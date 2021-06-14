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

namespace TP_PAV1
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            FormBarrios b = new FormBarrios();
            b.Show();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
            this.reportViewer7.RefreshReport();
            this.reportViewer8.RefreshReport();
            this.reportViewer9.RefreshReport();
            this.reportViewer10.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD.AD_Vehiculo.obtenerCantVehiculosPorModelo();

            ReportDataSource ds = new ReportDataSource("VehiculosPorModelo", tabla);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.LocalReport.Refresh();

        }
    }
}
