﻿using Microsoft.Reporting.WinForms;
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

            // TODO: esta línea de código carga datos en la tabla 'LocalesXTipoComercio.LocalesXTipoComercio' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportFedeListadoClientes.RefreshReport();
            this.reportFedeRegistroEstadias.RefreshReport();
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

        private void reportFedeListadoClientes_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Cliente.obtenerClientesXBarrio();
            ReportDataSource ds = new ReportDataSource("ClientesXBarrio", tabla);

            reportFedeListadoClientes.LocalReport.DataSources.Clear();
            reportFedeListadoClientes.LocalReport.DataSources.Add(ds);
            reportFedeListadoClientes.LocalReport.Refresh();
        }

        private void reportFedeRegistroEstadias_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_VariosXFede.ObtenerRegistroEstadias();
            ReportDataSource ds = new ReportDataSource("EstacionamientoXCliente", tabla);

            reportFedeRegistroEstadias.LocalReport.DataSources.Clear();
            reportFedeRegistroEstadias.LocalReport.DataSources.Add(ds);
            reportFedeRegistroEstadias.LocalReport.Refresh();
        }
    }
}