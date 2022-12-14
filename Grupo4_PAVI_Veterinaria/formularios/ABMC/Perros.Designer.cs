using System.Windows.Forms;

namespace Grupo4_PAVI_Veterinaria.formularios.abmcPerros
{
    partial class Perros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDueño = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.gdr_perros = new System.Windows.Forms.DataGridView();
            this.Nro_HC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNroHC = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_perros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(85, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión Perros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 69);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(134, 99);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(144, 20);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Raza";
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(134, 128);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(144, 21);
            this.cmbRaza.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Peso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Altura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dueño";
            // 
            // cmbDueño
            // 
            this.cmbDueño.FormattingEnabled = true;
            this.cmbDueño.Location = new System.Drawing.Point(134, 204);
            this.cmbDueño.Name = "cmbDueño";
            this.cmbDueño.Size = new System.Drawing.Size(144, 21);
            this.cmbDueño.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(78, 328);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 63);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Registrar;
            this.btnRegistrar.Location = new System.Drawing.Point(213, 328);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(64, 63);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(134, 153);
            this.txtPeso.MaxLength = 30;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(144, 20);
            this.txtPeso.TabIndex = 15;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(134, 179);
            this.txtAltura.MaxLength = 30;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(144, 20);
            this.txtAltura.TabIndex = 16;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gdr_perros
            // 
            this.gdr_perros.AllowUserToAddRows = false;
            this.gdr_perros.AllowUserToDeleteRows = false;
            this.gdr_perros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_perros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_HC,
            this.Nombre,
            this.Fecha_nacimiento,
            this.Id_Raza,
            this.Peso,
            this.Altura,
            this.Id_owner});
            this.gdr_perros.Location = new System.Drawing.Point(299, 12);
            this.gdr_perros.MultiSelect = false;
            this.gdr_perros.Name = "gdr_perros";
            this.gdr_perros.ReadOnly = true;
            this.gdr_perros.RowTemplate.Height = 25;
            this.gdr_perros.Size = new System.Drawing.Size(608, 285);
            this.gdr_perros.TabIndex = 17;
            this.gdr_perros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_perros_CellClick);
            // 
            // Nro_HC
            // 
            this.Nro_HC.DataPropertyName = "Nro_HC";
            this.Nro_HC.HeaderText = "N° H.Clinica";
            this.Nro_HC.Name = "Nro_HC";
            this.Nro_HC.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.DataPropertyName = "Fecha_nacimiento";
            this.Fecha_nacimiento.HeaderText = "Fecha Nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            // 
            // Id_Raza
            // 
            this.Id_Raza.DataPropertyName = "Denominacion";
            this.Id_Raza.HeaderText = "Raza";
            this.Id_Raza.Name = "Id_Raza";
            this.Id_Raza.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            // 
            // Altura
            // 
            this.Altura.DataPropertyName = "Altura";
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            // 
            // Id_owner
            // 
            this.Id_owner.DataPropertyName = "Dueño";
            this.Id_owner.HeaderText = "Dueño";
            this.Id_owner.Name = "Id_owner";
            this.Id_owner.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Actualizar;
            this.btnActualizar.Location = new System.Drawing.Point(147, 328);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(61, 63);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "N° Historia clínica";
            // 
            // txtNroHC
            // 
            this.txtNroHC.Enabled = false;
            this.txtNroHC.Location = new System.Drawing.Point(134, 39);
            this.txtNroHC.MaxLength = 30;
            this.txtNroHC.Name = "txtNroHC";
            this.txtNroHC.Size = new System.Drawing.Size(144, 20);
            this.txtNroHC.TabIndex = 20;
            this.txtNroHC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::Grupo4_PAVI_Veterinaria.Properties.Resources.Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(12, 328);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(61, 63);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Motivo de baja";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Enabled = false;
            this.txtMotivo.Location = new System.Drawing.Point(12, 251);
            this.txtMotivo.MaxLength = 50;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(264, 64);
            this.txtMotivo.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Nombre:";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Location = new System.Drawing.Point(351, 309);
            this.txtNombreBuscar.MaxLength = 30;
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(144, 20);
            this.txtNombreBuscar.TabIndex = 25;
            this.txtNombreBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(508, 309);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 20);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Perros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 402);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNroHC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gdr_perros);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbDueño);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Perros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perros";
            this.Load += new System.EventHandler(this.Perros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdr_perros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private MaskedTextBox txtFecha;
        private Label label4;
        private ComboBox cmbRaza;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbDueño;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private DataGridView gdr_perros;
        private Button btnActualizar;
        private DataGridViewTextBoxColumn Nro_HC;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Fecha_nacimiento;
        private DataGridViewTextBoxColumn Id_Raza;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn Altura;
        private DataGridViewTextBoxColumn Id_owner;
        private Label label8;
        private TextBox txtNroHC;
        private Button btnEliminar;
        private Label label9;
        private TextBox txtMotivo;
        private Label label10;
        private TextBox txtNombreBuscar;
        private Button btnBuscar;
    }
}