namespace TP_PAV1
{
    partial class FormProfesiones
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.grdProfesiones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.id_Profesiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesiones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(17, 281);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 44);
            this.btnActualizar.TabIndex = 36;
            this.btnActualizar.Text = "Actualizar Profesion";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(17, 216);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 44);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar Profesion";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(17, 349);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 44);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar Profesion";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Profesion:";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Location = new System.Drawing.Point(98, 119);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(147, 20);
            this.txtProfesion.TabIndex = 30;
            // 
            // grdProfesiones
            // 
            this.grdProfesiones.AllowUserToAddRows = false;
            this.grdProfesiones.AllowUserToDeleteRows = false;
            this.grdProfesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProfesiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Profesiones,
            this.nombre_profesion});
            this.grdProfesiones.Location = new System.Drawing.Point(266, 73);
            this.grdProfesiones.Name = "grdProfesiones";
            this.grdProfesiones.ReadOnly = true;
            this.grdProfesiones.Size = new System.Drawing.Size(277, 493);
            this.grdProfesiones.TabIndex = 32;
            this.grdProfesiones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProfesiones_CellClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(139)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(177, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Administrar Profesiones";
            // 
            // id_Profesiones
            // 
            this.id_Profesiones.DataPropertyName = "id_profesion";
            this.id_Profesiones.HeaderText = "id";
            this.id_Profesiones.Name = "id_Profesiones";
            this.id_Profesiones.ReadOnly = true;
            this.id_Profesiones.Width = 35;
            // 
            // nombre_profesion
            // 
            this.nombre_profesion.DataPropertyName = "nombre_profesion";
            this.nombre_profesion.HeaderText = "Profesión";
            this.nombre_profesion.Name = "nombre_profesion";
            this.nombre_profesion.ReadOnly = true;
            this.nombre_profesion.Width = 200;
            // 
            // FormProfesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(555, 684);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfesion);
            this.Controls.Add(this.grdProfesiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(555, 684);
            this.Name = "FormProfesiones";
            this.Text = "FormProfesiones";
            this.Load += new System.EventHandler(this.FormProfesiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProfesiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.DataGridView grdProfesiones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Profesiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_profesion;
    }
}