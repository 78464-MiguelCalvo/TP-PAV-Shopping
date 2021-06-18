namespace TP_PAV1
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VentasPorClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProcedimientosVentasX = new TP_PAV1.ProcedimientosVentasX();
            this.localescomercialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablasTPShopping = new TP_PAV1.TablasTPShopping();
            this.dataSetLocalesMasVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLocalesMasVentas = new TP_PAV1.DataSetLocalesMasVentas();
            this.TablaClientesXBarrioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetClientesXBarrio = new TP_PAV1.DataSetClientesXBarrio();
            this.label2 = new System.Windows.Forms.Label();
            this.ReporteCantidadArticulosPorTipo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.reportViewer7 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.reportViewer8 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.reportViewer9 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.reportViewer10 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ListadoClientes = new System.Windows.Forms.TabPage();
            this.reportViewer11 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BarriosQueMasCompran = new System.Windows.Forms.TabPage();
            this.reportViewer12 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VentasPorClienteTableAdapter = new TP_PAV1.ProcedimientosVentasXTableAdapters.VentasPorClienteTableAdapter();
            this.locales_comercialesTableAdapter = new TP_PAV1.TablasTPShoppingTableAdapters.locales_comercialesTableAdapter();
            this.locales_comercialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VentasPorClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedimientosVentasX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localescomercialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasTPShopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocalesMasVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocalesMasVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientesXBarrioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientesXBarrio)).BeginInit();
            this.ReporteCantidadArticulosPorTipo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.ListadoClientes.SuspendLayout();
            this.BarriosQueMasCompran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locales_comercialesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // VentasPorClienteBindingSource
            // 
            this.VentasPorClienteBindingSource.DataMember = "VentasPorCliente";
            this.VentasPorClienteBindingSource.DataSource = this.ProcedimientosVentasX;
            // 
            // ProcedimientosVentasX
            // 
            this.ProcedimientosVentasX.DataSetName = "ProcedimientosVentasX";
            this.ProcedimientosVentasX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localescomercialesBindingSource
            // 
            this.localescomercialesBindingSource.DataMember = "locales_comerciales";
            this.localescomercialesBindingSource.DataSource = this.tablasTPShopping;
            // 
            // tablasTPShopping
            // 
            this.tablasTPShopping.DataSetName = "TablasTPShopping";
            this.tablasTPShopping.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetLocalesMasVentasBindingSource
            // 
            this.dataSetLocalesMasVentasBindingSource.DataSource = this.dataSetLocalesMasVentas;
            this.dataSetLocalesMasVentasBindingSource.Position = 0;
            this.dataSetLocalesMasVentasBindingSource.CurrentChanged += new System.EventHandler(this.dataSetLocalesMasVentasBindingSource_CurrentChanged);
            // 
            // dataSetLocalesMasVentas
            // 
            this.dataSetLocalesMasVentas.DataSetName = "DataSetLocalesMasVentas";
            this.dataSetLocalesMasVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TablaClientesXBarrioBindingSource
            // 
            this.TablaClientesXBarrioBindingSource.DataMember = "TablaClientesXBarrio";
            this.TablaClientesXBarrioBindingSource.DataSource = this.DataSetClientesXBarrio;
            // 
            // DataSetClientesXBarrio
            // 
            this.DataSetClientesXBarrio.DataSetName = "DataSetClientesXBarrio";
            this.DataSetClientesXBarrio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(285, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reportes";
            // 
            // ReporteCantidadArticulosPorTipo
            // 
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage1);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage2);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage3);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage4);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage5);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage6);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage7);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage8);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage9);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.tabPage10);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.ListadoClientes);
            this.ReporteCantidadArticulosPorTipo.Controls.Add(this.BarriosQueMasCompran);
            this.ReporteCantidadArticulosPorTipo.Location = new System.Drawing.Point(16, 66);
            this.ReporteCantidadArticulosPorTipo.Margin = new System.Windows.Forms.Padding(4);
            this.ReporteCantidadArticulosPorTipo.Name = "ReporteCantidadArticulosPorTipo";
            this.ReporteCantidadArticulosPorTipo.SelectedIndex = 0;
            this.ReporteCantidadArticulosPorTipo.Size = new System.Drawing.Size(708, 761);
            this.ReporteCantidadArticulosPorTipo.TabIndex = 11;
            this.ReporteCantidadArticulosPorTipo.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(700, 732);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ReporteCantidadArticulosPorTipo";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteCantidadArticulosPorTipo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 4);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(692, 724);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(700, 732);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ReporteCantidadVehiculosPorMarca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteCantidadVehiculosPorMarca.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(4, 4);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(692, 724);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(700, 732);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ReporteCantidadVehiculosPorMes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteVehiculosPorMes.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(4, 4);
            this.reportViewer3.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(692, 724);
            this.reportViewer3.TabIndex = 0;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(700, 732);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ganancia por mes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteGananciaPorMes.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(4, 4);
            this.reportViewer4.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(692, 724);
            this.reportViewer4.TabIndex = 0;
            this.reportViewer4.Load += new System.EventHandler(this.reportViewer4_Load);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(700, 732);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Playas mas utilizadas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "TP_PAV1.ListadoDePlayasMasUtilizados.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(4, 4);
            this.reportViewer5.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(692, 724);
            this.reportViewer5.TabIndex = 0;
            this.reportViewer5.Load += new System.EventHandler(this.reportViewer5_Load);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.reportViewer6);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(700, 732);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "compras por cliente";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            this.reportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteComprasPorCliente.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(4, 4);
            this.reportViewer6.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(692, 724);
            this.reportViewer6.TabIndex = 0;
            this.reportViewer6.Load += new System.EventHandler(this.reportViewer6_Load);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.reportViewer7);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(700, 732);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Ventas por articulo";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // reportViewer7
            // 
            this.reportViewer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer7.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteVentasPorArticulo.rdlc";
            this.reportViewer7.Location = new System.Drawing.Point(4, 4);
            this.reportViewer7.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer7.Name = "reportViewer7";
            this.reportViewer7.ServerReport.BearerToken = null;
            this.reportViewer7.Size = new System.Drawing.Size(692, 724);
            this.reportViewer7.TabIndex = 0;
            this.reportViewer7.Load += new System.EventHandler(this.reportViewer7_Load_1);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.reportViewer8);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage8.Size = new System.Drawing.Size(700, 732);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Cantidad de ventas por Cliente";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // reportViewer8
            // 
            this.reportViewer8.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProcedimientosAlmacenados";
            reportDataSource1.Value = this.VentasPorClienteBindingSource;
            this.reportViewer8.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer8.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteCantVentasPorCliente.rdlc";
            this.reportViewer8.Location = new System.Drawing.Point(4, 4);
            this.reportViewer8.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer8.Name = "reportViewer8";
            this.reportViewer8.ServerReport.BearerToken = null;
            this.reportViewer8.Size = new System.Drawing.Size(692, 724);
            this.reportViewer8.TabIndex = 0;
            this.reportViewer8.Load += new System.EventHandler(this.reportViewer8_Load_1);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.reportViewer9);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage9.Size = new System.Drawing.Size(700, 732);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Listados de Locales";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // reportViewer9
            // 
            this.reportViewer9.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "VentasXLocal";
            reportDataSource2.Value = this.localescomercialesBindingSource;
            this.reportViewer9.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer9.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteVentasPorLocal.rdlc";
            this.reportViewer9.Location = new System.Drawing.Point(4, 4);
            this.reportViewer9.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer9.Name = "reportViewer9";
            this.reportViewer9.ServerReport.BearerToken = null;
            this.reportViewer9.Size = new System.Drawing.Size(692, 724);
            this.reportViewer9.TabIndex = 0;
            this.reportViewer9.Load += new System.EventHandler(this.reportViewer9_Load);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.reportViewer10);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage10.Size = new System.Drawing.Size(700, 732);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Locales por ventas";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // reportViewer10
            // 
            this.reportViewer10.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "LocalesMasVenta";
            reportDataSource3.Value = this.dataSetLocalesMasVentasBindingSource;
            this.reportViewer10.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer10.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteFedeCambiarNombreDespDeMerge.rdlc";
            this.reportViewer10.Location = new System.Drawing.Point(4, 4);
            this.reportViewer10.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer10.Name = "reportViewer10";
            this.reportViewer10.ServerReport.BearerToken = null;
            this.reportViewer10.Size = new System.Drawing.Size(692, 724);
            this.reportViewer10.TabIndex = 0;
            this.reportViewer10.Load += new System.EventHandler(this.reportViewer10_Load);
            // 
            // ListadoClientes
            // 
            this.ListadoClientes.Controls.Add(this.reportViewer11);
            this.ListadoClientes.Location = new System.Drawing.Point(4, 25);
            this.ListadoClientes.Margin = new System.Windows.Forms.Padding(4);
            this.ListadoClientes.Name = "ListadoClientes";
            this.ListadoClientes.Padding = new System.Windows.Forms.Padding(4);
            this.ListadoClientes.Size = new System.Drawing.Size(700, 732);
            this.ListadoClientes.TabIndex = 10;
            this.ListadoClientes.Text = "Listado de clientes";
            this.ListadoClientes.UseVisualStyleBackColor = true;
            // 
            // reportViewer11
            // 
            this.reportViewer11.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "ClientesXBarrio";
            reportDataSource4.Value = this.TablaClientesXBarrioBindingSource;
            this.reportViewer11.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer11.LocalReport.ReportEmbeddedResource = "TP_PAV1.ListadoClientes.rdlc";
            this.reportViewer11.Location = new System.Drawing.Point(4, 4);
            this.reportViewer11.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer11.Name = "reportViewer11";
            this.reportViewer11.ServerReport.BearerToken = null;
            this.reportViewer11.Size = new System.Drawing.Size(692, 724);
            this.reportViewer11.TabIndex = 0;
            this.reportViewer11.Load += new System.EventHandler(this.reportViewer11_Load);
            // 
            // BarriosQueMasCompran
            // 
            this.BarriosQueMasCompran.Controls.Add(this.reportViewer12);
            this.BarriosQueMasCompran.Location = new System.Drawing.Point(4, 25);
            this.BarriosQueMasCompran.Margin = new System.Windows.Forms.Padding(4);
            this.BarriosQueMasCompran.Name = "BarriosQueMasCompran";
            this.BarriosQueMasCompran.Padding = new System.Windows.Forms.Padding(4);
            this.BarriosQueMasCompran.Size = new System.Drawing.Size(700, 732);
            this.BarriosQueMasCompran.TabIndex = 11;
            this.BarriosQueMasCompran.Text = "Barrios con mas compras";
            this.BarriosQueMasCompran.UseVisualStyleBackColor = true;
            // 
            // reportViewer12
            // 
            this.reportViewer12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer12.LocalReport.ReportEmbeddedResource = "TP_PAV1.ReporteVentasXBarrio.rdlc";
            this.reportViewer12.Location = new System.Drawing.Point(4, 4);
            this.reportViewer12.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer12.Name = "reportViewer12";
            this.reportViewer12.ServerReport.BearerToken = null;
            this.reportViewer12.Size = new System.Drawing.Size(692, 724);
            this.reportViewer12.TabIndex = 0;
            this.reportViewer12.Load += new System.EventHandler(this.reportViewer12_Load);
            // 
            // VentasPorClienteTableAdapter
            // 
            this.VentasPorClienteTableAdapter.ClearBeforeFill = true;
            // 
            // locales_comercialesTableAdapter
            // 
            this.locales_comercialesTableAdapter.ClearBeforeFill = true;
            // 
            // locales_comercialesBindingSource
            // 
            this.locales_comercialesBindingSource.DataMember = "locales_comerciales";
            this.locales_comercialesBindingSource.DataSource = this.tablasTPShopping;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(740, 842);
            this.Controls.Add(this.ReporteCantidadArticulosPorTipo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(740, 842);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasPorClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcedimientosVentasX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localescomercialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablasTPShopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocalesMasVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLocalesMasVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaClientesXBarrioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetClientesXBarrio)).EndInit();
            this.ReporteCantidadArticulosPorTipo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.ListadoClientes.ResumeLayout(false);
            this.BarriosQueMasCompran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.locales_comercialesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl ReporteCantidadArticulosPorTipo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer7;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer8;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer9;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer10;
        private System.Windows.Forms.BindingSource VentasPorClienteBindingSource;
        private ProcedimientosVentasX ProcedimientosVentasX;
        private ProcedimientosVentasXTableAdapters.VentasPorClienteTableAdapter VentasPorClienteTableAdapter;
        private TablasTPShopping tablasTPShopping;
        private System.Windows.Forms.BindingSource localescomercialesBindingSource;
        private TablasTPShoppingTableAdapters.locales_comercialesTableAdapter locales_comercialesTableAdapter;
        private System.Windows.Forms.BindingSource dataSetLocalesMasVentasBindingSource;
        private DataSetLocalesMasVentas dataSetLocalesMasVentas;
        private System.Windows.Forms.TabPage ListadoClientes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer11;
        private System.Windows.Forms.BindingSource TablaClientesXBarrioBindingSource;
        private DataSetClientesXBarrio DataSetClientesXBarrio;
        private System.Windows.Forms.TabPage BarriosQueMasCompran;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer12;
        private System.Windows.Forms.BindingSource locales_comercialesBindingSource;
    }
}