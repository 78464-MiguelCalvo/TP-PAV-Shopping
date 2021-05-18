namespace TP_PAV1
{
    partial class FormVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehiculos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PICBuscar = new System.Windows.Forms.PictureBox();
            this.txtBuscarPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaVehiculos = new System.Windows.Forms.DataGridView();
            this.PICAgregarVehuciulo = new System.Windows.Forms.PictureBox();
            this.PICEliminarVehiculo = new System.Windows.Forms.PictureBox();
            this.PICModificarVehiculo = new System.Windows.Forms.PictureBox();
            this.PICActualizarGrilla = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICAgregarVehuciulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICEliminarVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICModificarVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICActualizarGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PICBuscar);
            this.groupBox1.Controls.Add(this.txtBuscarPatente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // PICBuscar
            // 
            this.PICBuscar.Image = ((System.Drawing.Image)(resources.GetObject("PICBuscar.Image")));
            this.PICBuscar.Location = new System.Drawing.Point(393, 35);
            this.PICBuscar.Name = "PICBuscar";
            this.PICBuscar.Size = new System.Drawing.Size(25, 26);
            this.PICBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBuscar.TabIndex = 2;
            this.PICBuscar.TabStop = false;
            // 
            // txtBuscarPatente
            // 
            this.txtBuscarPatente.Location = new System.Drawing.Point(145, 36);
            this.txtBuscarPatente.Name = "txtBuscarPatente";
            this.txtBuscarPatente.Size = new System.Drawing.Size(242, 25);
            this.txtBuscarPatente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente";
            // 
            // GrillaVehiculos
            // 
            this.GrillaVehiculos.AllowUserToAddRows = false;
            this.GrillaVehiculos.AllowUserToDeleteRows = false;
            this.GrillaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaVehiculos.Location = new System.Drawing.Point(13, 131);
            this.GrillaVehiculos.Name = "GrillaVehiculos";
            this.GrillaVehiculos.ReadOnly = true;
            this.GrillaVehiculos.Size = new System.Drawing.Size(518, 473);
            this.GrillaVehiculos.TabIndex = 1;
            this.GrillaVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaVehiculos_CellClick);
            // 
            // PICAgregarVehuciulo
            // 
            this.PICAgregarVehuciulo.Image = ((System.Drawing.Image)(resources.GetObject("PICAgregarVehuciulo.Image")));
            this.PICAgregarVehuciulo.Location = new System.Drawing.Point(13, 611);
            this.PICAgregarVehuciulo.Name = "PICAgregarVehuciulo";
            this.PICAgregarVehuciulo.Size = new System.Drawing.Size(40, 50);
            this.PICAgregarVehuciulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICAgregarVehuciulo.TabIndex = 2;
            this.PICAgregarVehuciulo.TabStop = false;
            this.PICAgregarVehuciulo.Click += new System.EventHandler(this.PICAgregarVehuciulo_Click);
            // 
            // PICEliminarVehiculo
            // 
            this.PICEliminarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("PICEliminarVehiculo.Image")));
            this.PICEliminarVehiculo.Location = new System.Drawing.Point(59, 611);
            this.PICEliminarVehiculo.Name = "PICEliminarVehiculo";
            this.PICEliminarVehiculo.Size = new System.Drawing.Size(40, 50);
            this.PICEliminarVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICEliminarVehiculo.TabIndex = 3;
            this.PICEliminarVehiculo.TabStop = false;
            this.PICEliminarVehiculo.Click += new System.EventHandler(this.PICEliminarVehiculo_Click);
            // 
            // PICModificarVehiculo
            // 
            this.PICModificarVehiculo.Image = ((System.Drawing.Image)(resources.GetObject("PICModificarVehiculo.Image")));
            this.PICModificarVehiculo.Location = new System.Drawing.Point(105, 611);
            this.PICModificarVehiculo.Name = "PICModificarVehiculo";
            this.PICModificarVehiculo.Size = new System.Drawing.Size(40, 50);
            this.PICModificarVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICModificarVehiculo.TabIndex = 4;
            this.PICModificarVehiculo.TabStop = false;
            this.PICModificarVehiculo.Click += new System.EventHandler(this.PICModificarVehiculo_Click);
            // 
            // PICActualizarGrilla
            // 
            this.PICActualizarGrilla.Image = ((System.Drawing.Image)(resources.GetObject("PICActualizarGrilla.Image")));
            this.PICActualizarGrilla.Location = new System.Drawing.Point(151, 611);
            this.PICActualizarGrilla.Name = "PICActualizarGrilla";
            this.PICActualizarGrilla.Size = new System.Drawing.Size(40, 50);
            this.PICActualizarGrilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICActualizarGrilla.TabIndex = 5;
            this.PICActualizarGrilla.TabStop = false;
            this.PICActualizarGrilla.Click += new System.EventHandler(this.PICActualizarGrilla_Click);
            // 
            // FormVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(555, 684);
            this.Controls.Add(this.PICActualizarGrilla);
            this.Controls.Add(this.PICModificarVehiculo);
            this.Controls.Add(this.PICEliminarVehiculo);
            this.Controls.Add(this.PICAgregarVehuciulo);
            this.Controls.Add(this.GrillaVehiculos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(555, 684);
            this.Name = "FormVehiculos";
            this.Text = "FormVehiculos";
            this.Load += new System.EventHandler(this.FormVehiculos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICAgregarVehuciulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICEliminarVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICModificarVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICActualizarGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PICBuscar;
        private System.Windows.Forms.TextBox txtBuscarPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaVehiculos;
        private System.Windows.Forms.PictureBox PICAgregarVehuciulo;
        private System.Windows.Forms.PictureBox PICEliminarVehiculo;
        private System.Windows.Forms.PictureBox PICModificarVehiculo;
        private System.Windows.Forms.PictureBox PICActualizarGrilla;
    }
}