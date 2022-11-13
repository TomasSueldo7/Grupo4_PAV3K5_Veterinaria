using System.Windows.Forms;

namespace Grupo4_PAVI_Veterinaria.formularios.abmcDueños
{
    partial class Dueños
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dueños));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.txtApellidoDueño = new System.Windows.Forms.TextBox();
            this.txtTelefonoDueño = new System.Windows.Forms.MaskedTextBox();
            this.contenedorDatosDueños = new System.Windows.Forms.GroupBox();
            this.txtNroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.contenedorGrillaDueños = new System.Windows.Forms.GroupBox();
            this.gdrDueños = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.contenedorDatosDueños.SuspendLayout();
            this.contenedorGrillaDueños.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrDueños)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Dueño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(51, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(51, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(51, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Location = new System.Drawing.Point(135, 16);
            this.txtNombreDueño.MaxLength = 30;
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(106, 27);
            this.txtNombreDueño.TabIndex = 4;
            // 
            // txtApellidoDueño
            // 
            this.txtApellidoDueño.Location = new System.Drawing.Point(135, 49);
            this.txtApellidoDueño.MaxLength = 30;
            this.txtApellidoDueño.Name = "txtApellidoDueño";
            this.txtApellidoDueño.Size = new System.Drawing.Size(106, 27);
            this.txtApellidoDueño.TabIndex = 5;
            // 
            // txtTelefonoDueño
            // 
            this.txtTelefonoDueño.Location = new System.Drawing.Point(135, 82);
            this.txtTelefonoDueño.Mask = "000-0000";
            this.txtTelefonoDueño.Name = "txtTelefonoDueño";
            this.txtTelefonoDueño.Size = new System.Drawing.Size(106, 27);
            this.txtTelefonoDueño.TabIndex = 6;
            // 
            // contenedorDatosDueños
            // 
            this.contenedorDatosDueños.Controls.Add(this.txtNroDocumento);
            this.contenedorDatosDueños.Controls.Add(this.btnActualizar);
            this.contenedorDatosDueños.Controls.Add(this.cmbTipoDoc);
            this.contenedorDatosDueños.Controls.Add(this.btnRegistrar);
            this.contenedorDatosDueños.Controls.Add(this.lblNroDocumento);
            this.contenedorDatosDueños.Controls.Add(this.btnLimpiar);
            this.contenedorDatosDueños.Controls.Add(this.lblTipoDocumento);
            this.contenedorDatosDueños.Controls.Add(this.btnEliminar);
            this.contenedorDatosDueños.Controls.Add(this.txtTelefonoDueño);
            this.contenedorDatosDueños.Controls.Add(this.txtApellidoDueño);
            this.contenedorDatosDueños.Controls.Add(this.txtNombreDueño);
            this.contenedorDatosDueños.Controls.Add(this.label4);
            this.contenedorDatosDueños.Controls.Add(this.label3);
            this.contenedorDatosDueños.Controls.Add(this.label2);
            this.contenedorDatosDueños.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.contenedorDatosDueños.Location = new System.Drawing.Point(12, 29);
            this.contenedorDatosDueños.Name = "contenedorDatosDueños";
            this.contenedorDatosDueños.Size = new System.Drawing.Size(482, 186);
            this.contenedorDatosDueños.TabIndex = 11;
            this.contenedorDatosDueños.TabStop = false;
            this.contenedorDatosDueños.Text = "Datos Dueño";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(135, 153);
            this.txtNroDocumento.Mask = "99999999";
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(106, 27);
            this.txtNroDocumento.TabIndex = 19;
            this.txtNroDocumento.ValidatingType = typeof(int);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(135, 119);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(106, 28);
            this.cmbTipoDoc.TabIndex = 18;
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Location = new System.Drawing.Point(10, 155);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(119, 20);
            this.lblNroDocumento.TabIndex = 17;
            this.lblNroDocumento.Text = "Nro Documento:";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(6, 125);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(124, 20);
            this.lblTipoDocumento.TabIndex = 16;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // contenedorGrillaDueños
            // 
            this.contenedorGrillaDueños.Controls.Add(this.gdrDueños);
            this.contenedorGrillaDueños.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.contenedorGrillaDueños.Location = new System.Drawing.Point(12, 211);
            this.contenedorGrillaDueños.Name = "contenedorGrillaDueños";
            this.contenedorGrillaDueños.Size = new System.Drawing.Size(482, 169);
            this.contenedorGrillaDueños.TabIndex = 12;
            this.contenedorGrillaDueños.TabStop = false;
            this.contenedorGrillaDueños.Text = "Listado Dueños";
            // 
            // gdrDueños
            // 
            this.gdrDueños.AllowUserToAddRows = false;
            this.gdrDueños.AllowUserToDeleteRows = false;
            this.gdrDueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrDueños.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Documento,
            this.Telefono});
            this.gdrDueños.Location = new System.Drawing.Point(5, 23);
            this.gdrDueños.Name = "gdrDueños";
            this.gdrDueños.ReadOnly = true;
            this.gdrDueños.RowTemplate.Height = 25;
            this.gdrDueños.Size = new System.Drawing.Size(477, 136);
            this.gdrDueños.TabIndex = 0;
            this.gdrDueños.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrDueños_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "nro_doc";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 150;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Actualizar;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.Location = new System.Drawing.Point(261, 98);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(87, 77);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Registrar;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.Location = new System.Drawing.Point(369, 18);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 74);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Limpiar;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(261, 18);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 74);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.Location = new System.Drawing.Point(369, 98);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 77);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Dueños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 391);
            this.Controls.Add(this.contenedorGrillaDueños);
            this.Controls.Add(this.contenedorDatosDueños);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dueños";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dueños";
            this.Load += new System.EventHandler(this.Dueños_Load);
            this.contenedorDatosDueños.ResumeLayout(false);
            this.contenedorDatosDueños.PerformLayout();
            this.contenedorGrillaDueños.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdrDueños)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreDueño;
        private TextBox txtApellidoDueño;
        private MaskedTextBox txtTelefonoDueño;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Button btnActualizar;
        private GroupBox contenedorDatosDueños;
        private GroupBox contenedorGrillaDueños;
        private DataGridView gdrDueños;
        private DataGridViewTextBoxColumn Teléfono;
        private MaskedTextBox txtNroDocumento;
        private ComboBox cmbTipoDoc;
        private Label lblNroDocumento;
        private Label lblTipoDocumento;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Telefono;
    }
}