namespace TP_PAV1
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtnOtro = new System.Windows.Forms.RadioButton();
            this.rdBtnFemenino = new System.Windows.Forms.RadioButton();
            this.rdBtnMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNroDomicilio = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdBtnCasado = new System.Windows.Forms.RadioButton();
            this.rdBtnSoltero = new System.Windows.Forms.RadioButton();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevoEstacionamiento = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Administrar Clientes";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(194, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(194, 74);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(129, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de nac.:";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(194, 103);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(129, 20);
            this.txtFechaNacimiento.TabIndex = 10;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoDoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNroDoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documento";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(6, 52);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(96, 28);
            this.cmbTipoDoc.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tipo:";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(105, 52);
            this.txtNroDoc.Mask = "99999999";
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(89, 26);
            this.txtNroDoc.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(114, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Numero:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(229, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdBtnOtro);
            this.panel1.Controls.Add(this.rdBtnFemenino);
            this.panel1.Controls.Add(this.rdBtnMasculino);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(14, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 69);
            this.panel1.TabIndex = 15;
            // 
            // rdBtnOtro
            // 
            this.rdBtnOtro.AutoSize = true;
            this.rdBtnOtro.ForeColor = System.Drawing.Color.White;
            this.rdBtnOtro.Location = new System.Drawing.Point(15, 43);
            this.rdBtnOtro.Name = "rdBtnOtro";
            this.rdBtnOtro.Size = new System.Drawing.Size(58, 24);
            this.rdBtnOtro.TabIndex = 13;
            this.rdBtnOtro.TabStop = true;
            this.rdBtnOtro.Text = "Otro";
            this.rdBtnOtro.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemenino
            // 
            this.rdBtnFemenino.AutoSize = true;
            this.rdBtnFemenino.ForeColor = System.Drawing.Color.White;
            this.rdBtnFemenino.Location = new System.Drawing.Point(15, 3);
            this.rdBtnFemenino.Name = "rdBtnFemenino";
            this.rdBtnFemenino.Size = new System.Drawing.Size(98, 24);
            this.rdBtnFemenino.TabIndex = 11;
            this.rdBtnFemenino.TabStop = true;
            this.rdBtnFemenino.Text = "Femenino";
            this.rdBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rdBtnMasculino
            // 
            this.rdBtnMasculino.AutoSize = true;
            this.rdBtnMasculino.ForeColor = System.Drawing.Color.White;
            this.rdBtnMasculino.Location = new System.Drawing.Point(15, 23);
            this.rdBtnMasculino.Name = "rdBtnMasculino";
            this.rdBtnMasculino.Size = new System.Drawing.Size(98, 24);
            this.rdBtnMasculino.TabIndex = 12;
            this.rdBtnMasculino.TabStop = true;
            this.rdBtnMasculino.Text = "Masculino";
            this.rdBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbBarrio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtNroDomicilio);
            this.groupBox3.Controls.Add(this.txtCalle);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 103);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Domicilio";
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(117, 25);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(182, 28);
            this.cmbBarrio.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(61, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Barrio:";
            // 
            // txtNroDomicilio
            // 
            this.txtNroDomicilio.Location = new System.Drawing.Point(286, 59);
            this.txtNroDomicilio.Name = "txtNroDomicilio";
            this.txtNroDomicilio.Size = new System.Drawing.Size(49, 26);
            this.txtNroDomicilio.TabIndex = 23;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(71, 59);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(129, 26);
            this.txtCalle.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Calle:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(219, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Numero:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdBtnCasado);
            this.groupBox4.Controls.Add(this.rdBtnSoltero);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 383);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 57);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado civil";
            // 
            // rdBtnCasado
            // 
            this.rdBtnCasado.AutoSize = true;
            this.rdBtnCasado.ForeColor = System.Drawing.Color.White;
            this.rdBtnCasado.Location = new System.Drawing.Point(199, 25);
            this.rdBtnCasado.Name = "rdBtnCasado";
            this.rdBtnCasado.Size = new System.Drawing.Size(82, 24);
            this.rdBtnCasado.TabIndex = 13;
            this.rdBtnCasado.TabStop = true;
            this.rdBtnCasado.Text = "Casado";
            this.rdBtnCasado.UseVisualStyleBackColor = true;
            // 
            // rdBtnSoltero
            // 
            this.rdBtnSoltero.AutoSize = true;
            this.rdBtnSoltero.ForeColor = System.Drawing.Color.White;
            this.rdBtnSoltero.Location = new System.Drawing.Point(71, 25);
            this.rdBtnSoltero.Name = "rdBtnSoltero";
            this.rdBtnSoltero.Size = new System.Drawing.Size(78, 24);
            this.rdBtnSoltero.TabIndex = 12;
            this.rdBtnSoltero.TabStop = true;
            this.rdBtnSoltero.Text = "Soltero";
            this.rdBtnSoltero.UseVisualStyleBackColor = true;
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apellido,
            this.nombre,
            this.tipoDoc,
            this.nroDoc});
            this.grdClientes.Location = new System.Drawing.Point(12, 460);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.Size = new System.Drawing.Size(487, 212);
            this.grdClientes.TabIndex = 26;
            this.grdClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellClick);
            this.grdClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellContentClick);
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 130;
            // 
            // tipoDoc
            // 
            this.tipoDoc.DataPropertyName = "tipo_documento";
            this.tipoDoc.HeaderText = "Tipo Doc";
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            this.tipoDoc.Width = 70;
            // 
            // nroDoc
            // 
            this.nroDoc.DataPropertyName = "nro_documento";
            this.nroDoc.HeaderText = "Nro. Doc.";
            this.nroDoc.Name = "nroDoc";
            this.nroDoc.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(424, 299);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 44);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Location = new System.Drawing.Point(424, 383);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(75, 44);
            this.btnLimpiarDatos.TabIndex = 28;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(424, 153);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(75, 44);
            this.btnGuardarCliente.TabIndex = 27;
            this.btnGuardarCliente.Text = "Guardar Cliente";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(424, 220);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 44);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "Actualizar Cliente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevoEstacionamiento
            // 
            this.btnNuevoEstacionamiento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNuevoEstacionamiento.FlatAppearance.BorderSize = 0;
            this.btnNuevoEstacionamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.btnNuevoEstacionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEstacionamiento.ForeColor = System.Drawing.Color.White;
            this.btnNuevoEstacionamiento.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEstacionamiento.Image")));
            this.btnNuevoEstacionamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEstacionamiento.Location = new System.Drawing.Point(298, 44);
            this.btnNuevoEstacionamiento.Name = "btnNuevoEstacionamiento";
            this.btnNuevoEstacionamiento.Size = new System.Drawing.Size(226, 50);
            this.btnNuevoEstacionamiento.TabIndex = 30;
            this.btnNuevoEstacionamiento.Text = "            Nuevo estacionamiento";
            this.btnNuevoEstacionamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEstacionamiento.UseVisualStyleBackColor = false;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(555, 684);
            this.Controls.Add(this.btnNuevoEstacionamiento);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.grdClientes);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(555, 684);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtNroDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnOtro;
        private System.Windows.Forms.RadioButton rdBtnFemenino;
        private System.Windows.Forms.RadioButton rdBtnMasculino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNroDomicilio;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdBtnCasado;
        private System.Windows.Forms.RadioButton rdBtnSoltero;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDoc;
        private System.Windows.Forms.Button btnNuevoEstacionamiento;
    }
}