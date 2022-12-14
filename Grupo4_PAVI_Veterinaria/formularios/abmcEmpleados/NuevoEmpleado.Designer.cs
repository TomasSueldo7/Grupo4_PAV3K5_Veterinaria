using System.Windows.Forms;

namespace Grupo4_PAVI_Veterinaria.formularios.abmcEmpleados
{
    partial class NuevoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoEmpleado));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.txtNroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.txtMatricula = new System.Windows.Forms.MaskedTextBox();
            this.gdrEmpleados = new System.Windows.Forms.DataGridView();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Empleado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(59, 93);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(54, 127);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDocumento.TabIndex = 4;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(57, 158);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(85, 13);
            this.lblNroDocumento.TabIndex = 5;
            this.lblNroDocumento.Text = "Nro Documento:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(54, 227);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(78, 13);
            this.lblFechaIngreso.TabIndex = 6;
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(54, 189);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNacimiento.TabIndex = 7;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(54, 260);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 8;
            this.lblMatricula.Text = "Matricula:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(181, 120);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDoc.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 57);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(181, 86);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 11;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(181, 186);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(121, 20);
            this.txtFechaNacimiento.TabIndex = 13;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(181, 220);
            this.txtFechaIngreso.Mask = "00/00/0000";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(121, 20);
            this.txtFechaIngreso.TabIndex = 14;
            this.txtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(181, 151);
            this.txtNroDocumento.Mask = "99999999";
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(121, 20);
            this.txtNroDocumento.TabIndex = 15;
            this.txtNroDocumento.ValidatingType = typeof(int);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(181, 253);
            this.txtMatricula.Mask = "99999";
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(121, 20);
            this.txtMatricula.TabIndex = 16;
            this.txtMatricula.ValidatingType = typeof(int);
            // 
            // gdrEmpleados
            // 
            this.gdrEmpleados.AllowUserToAddRows = false;
            this.gdrEmpleados.AllowUserToDeleteRows = false;
            this.gdrEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaNombre,
            this.ColumnaApellido,
            this.Documento});
            this.gdrEmpleados.Location = new System.Drawing.Point(336, 57);
            this.gdrEmpleados.Name = "gdrEmpleados";
            this.gdrEmpleados.ReadOnly = true;
            this.gdrEmpleados.RowTemplate.Height = 25;
            this.gdrEmpleados.Size = new System.Drawing.Size(325, 237);
            this.gdrEmpleados.TabIndex = 19;
            this.gdrEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEmpleados_CellClick);
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.DataPropertyName = "Nombre";
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            this.ColumnaNombre.Width = 120;
            // 
            // ColumnaApellido
            // 
            this.ColumnaApellido.DataPropertyName = "Apellido";
            this.ColumnaApellido.HeaderText = "Apellido";
            this.ColumnaApellido.Name = "ColumnaApellido";
            this.ColumnaApellido.ReadOnly = true;
            this.ColumnaApellido.Width = 120;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Nro_doc";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(12, 300);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 68);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnBaja
            // 
            this.btnBaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaja.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Eliminar;
            this.btnBaja.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaja.Location = new System.Drawing.Point(264, 300);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(80, 68);
            this.btnBaja.TabIndex = 21;
            this.btnBaja.Text = "Eliminar";
            this.btnBaja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Actualizar;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.Location = new System.Drawing.Point(89, 300);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(76, 68);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Registrar;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.Location = new System.Drawing.Point(171, 300);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 68);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Registrar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // NuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 390);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gdrEmpleados);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoEmpleado";
            this.Load += new System.EventHandler(this.NuevoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipoDocumento;
        private Label lblNroDocumento;
        private Label lblFechaIngreso;
        private Label lblFechaNacimiento;
        private Label lblMatricula;
        private ComboBox cmbTipoDoc;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private MaskedTextBox txtFechaNacimiento;
        private MaskedTextBox txtFechaIngreso;
        private MaskedTextBox txtNroDocumento;
        private MaskedTextBox txtMatricula;
        private Button btnAceptar;
        private DataGridView gdrEmpleados;
        private Button btnActualizar;
        private Button btnBaja;
        private Button btnLimpiar;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn Documento;
    }
}