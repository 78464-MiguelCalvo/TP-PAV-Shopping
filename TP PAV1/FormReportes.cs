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
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G12_2021DataSet1.ArticulosXLocal' Puede moverla o quitarla según sea necesario.
            this.ArticulosXLocalTableAdapter.Fill(this.BD3K7G12_2021DataSet1.ArticulosXLocal);
            // TODO: esta línea de código carga datos en la tabla 'BD3K7G12_2021DataSet.LocalesXTipoComercio' Puede moverla o quitarla según sea necesario.
            this.LocalesXTipoComercioTableAdapter.Fill(this.BD3K7G12_2021DataSet.LocalesXTipoComercio);

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

        private void reportViewer3_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Locales.ObtenerLocalesXRubro();

            ReportDataSource ds = new ReportDataSource("DatosLocalesXRubro", tabla);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.LocalReport.Refresh();

        }

        private void reportViewer4_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_ArticuloXLocal.ObtenerArticuloXLocal();

            ReportDataSource ds = new ReportDataSource("ArticulosXLocal", tabla);

            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.LocalReport.Refresh();
        }
    }
}
