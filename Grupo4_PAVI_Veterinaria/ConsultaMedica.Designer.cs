using System.Windows.Forms;

namespace Grupo4_PAVI_Veterinaria
{
    partial class ConsultaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMedica));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroHC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMedicamentos = new System.Windows.Forms.ComboBox();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.grdMedicamentos = new System.Windows.Forms.DataGridView();
            this.Id_Medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarMedicamentos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarSintomas = new System.Windows.Forms.Button();
            this.cmbSintomas = new System.Windows.Forms.ComboBox();
            this.gdrSintomas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarSintomas = new System.Windows.Forms.Button();
            this.txtSintoma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNroConsulta = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarMedicamento = new System.Windows.Forms.Button();
            this.btnEliminarSintoma = new System.Windows.Forms.Button();
            this.btnLimpiarSintomas = new System.Windows.Forms.Button();
            this.btnLimpiarMedicamentos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicamentos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSintomas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Historia Clínica";
            // 
            // txtNroHC
            // 
            this.txtNroHC.Enabled = false;
            this.txtNroHC.Location = new System.Drawing.Point(141, 62);
            this.txtNroHC.Name = "txtNroHC";
            this.txtNroHC.Size = new System.Drawing.Size(133, 20);
            this.txtNroHC.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarMedicamentos);
            this.groupBox1.Controls.Add(this.btnEliminarMedicamento);
            this.groupBox1.Controls.Add(this.cmbMedicamentos);
            this.groupBox1.Controls.Add(this.btnAgregarM);
            this.groupBox1.Controls.Add(this.txtMedicamento);
            this.groupBox1.Controls.Add(this.grdMedicamentos);
            this.groupBox1.Controls.Add(this.btnBuscarMedicamentos);
            this.groupBox1.Location = new System.Drawing.Point(20, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 295);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicamentos";
            // 
            // cmbMedicamentos
            // 
            this.cmbMedicamentos.FormattingEnabled = true;
            this.cmbMedicamentos.Location = new System.Drawing.Point(39, 62);
            this.cmbMedicamentos.Name = "cmbMedicamentos";
            this.cmbMedicamentos.Size = new System.Drawing.Size(133, 21);
            this.cmbMedicamentos.TabIndex = 25;
            this.cmbMedicamentos.SelectedIndexChanged += new System.EventHandler(this.cmbMedicamentos_SelectedIndexChanged);
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.Location = new System.Drawing.Point(191, 62);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(62, 24);
            this.btnAgregarM.TabIndex = 24;
            this.btnAgregarM.Text = "Agregar";
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(39, 29);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(133, 20);
            this.txtMedicamento.TabIndex = 23;
            // 
            // grdMedicamentos
            // 
            this.grdMedicamentos.AllowUserToAddRows = false;
            this.grdMedicamentos.AllowUserToDeleteRows = false;
            this.grdMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Medicamento,
            this.Descripcion});
            this.grdMedicamentos.Location = new System.Drawing.Point(11, 130);
            this.grdMedicamentos.Name = "grdMedicamentos";
            this.grdMedicamentos.ReadOnly = true;
            this.grdMedicamentos.RowTemplate.Height = 25;
            this.grdMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMedicamentos.Size = new System.Drawing.Size(262, 159);
            this.grdMedicamentos.TabIndex = 4;
            this.grdMedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMedicamentos_CellClick);
            // 
            // Id_Medicamento
            // 
            this.Id_Medicamento.DataPropertyName = "Descripcion";
            this.Id_Medicamento.HeaderText = "ID";
            this.Id_Medicamento.Name = "Id_Medicamento";
            this.Id_Medicamento.ReadOnly = true;
            this.Id_Medicamento.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 210;
            // 
            // btnBuscarMedicamentos
            // 
            this.btnBuscarMedicamentos.Location = new System.Drawing.Point(191, 26);
            this.btnBuscarMedicamentos.Name = "btnBuscarMedicamentos";
            this.btnBuscarMedicamentos.Size = new System.Drawing.Size(62, 24);
            this.btnBuscarMedicamentos.TabIndex = 6;
            this.btnBuscarMedicamentos.Text = "Buscar";
            this.btnBuscarMedicamentos.UseVisualStyleBackColor = true;
            this.btnBuscarMedicamentos.Click += new System.EventHandler(this.btnBuscarMedicamentos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiarSintomas);
            this.groupBox2.Controls.Add(this.btnEliminarSintoma);
            this.groupBox2.Controls.Add(this.btnBuscarSintomas);
            this.groupBox2.Controls.Add(this.cmbSintomas);
            this.groupBox2.Controls.Add(this.gdrSintomas);
            this.groupBox2.Controls.Add(this.btnAgregarSintomas);
            this.groupBox2.Controls.Add(this.txtSintoma);
            this.groupBox2.Location = new System.Drawing.Point(309, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 295);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sintomas";
            // 
            // btnBuscarSintomas
            // 
            this.btnBuscarSintomas.Location = new System.Drawing.Point(182, 26);
            this.btnBuscarSintomas.Name = "btnBuscarSintomas";
            this.btnBuscarSintomas.Size = new System.Drawing.Size(62, 24);
            this.btnBuscarSintomas.TabIndex = 8;
            this.btnBuscarSintomas.Text = "Buscar";
            this.btnBuscarSintomas.UseVisualStyleBackColor = true;
            this.btnBuscarSintomas.Click += new System.EventHandler(this.btnBuscarSintomas_Click);
            // 
            // cmbSintomas
            // 
            this.cmbSintomas.FormattingEnabled = true;
            this.cmbSintomas.Location = new System.Drawing.Point(30, 61);
            this.cmbSintomas.Name = "cmbSintomas";
            this.cmbSintomas.Size = new System.Drawing.Size(133, 21);
            this.cmbSintomas.TabIndex = 29;
            // 
            // gdrSintomas
            // 
            this.gdrSintomas.AllowUserToAddRows = false;
            this.gdrSintomas.AllowUserToDeleteRows = false;
            this.gdrSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSintomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gdrSintomas.Location = new System.Drawing.Point(4, 130);
            this.gdrSintomas.Name = "gdrSintomas";
            this.gdrSintomas.ReadOnly = true;
            this.gdrSintomas.RowTemplate.Height = 25;
            this.gdrSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdrSintomas.Size = new System.Drawing.Size(267, 159);
            this.gdrSintomas.TabIndex = 4;
            this.gdrSintomas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrSintomas_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 210;
            // 
            // btnAgregarSintomas
            // 
            this.btnAgregarSintomas.Location = new System.Drawing.Point(182, 61);
            this.btnAgregarSintomas.Name = "btnAgregarSintomas";
            this.btnAgregarSintomas.Size = new System.Drawing.Size(62, 24);
            this.btnAgregarSintomas.TabIndex = 28;
            this.btnAgregarSintomas.Text = "Agregar";
            this.btnAgregarSintomas.UseVisualStyleBackColor = true;
            this.btnAgregarSintomas.Click += new System.EventHandler(this.btnAgregarSintomas_Click);
            // 
            // txtSintoma
            // 
            this.txtSintoma.Location = new System.Drawing.Point(30, 29);
            this.txtSintoma.Name = "txtSintoma";
            this.txtSintoma.Size = new System.Drawing.Size(133, 20);
            this.txtSintoma.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Peso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Altura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Dueño";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(141, 125);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(133, 20);
            this.txtFechaNacimiento.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(141, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtDueño
            // 
            this.txtDueño.Enabled = false;
            this.txtDueño.Location = new System.Drawing.Point(411, 62);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(133, 20);
            this.txtDueño.TabIndex = 15;
            // 
            // txtPeso
            // 
            this.txtPeso.Enabled = false;
            this.txtPeso.Location = new System.Drawing.Point(411, 29);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(133, 20);
            this.txtPeso.TabIndex = 16;
            // 
            // txtAltura
            // 
            this.txtAltura.Enabled = false;
            this.txtAltura.Location = new System.Drawing.Point(411, 92);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(133, 20);
            this.txtAltura.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Legajo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNroConsulta);
            this.groupBox3.Controls.Add(this.txtRaza);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.txtAltura);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtNroHC);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDueño);
            this.groupBox3.Controls.Add(this.txtPeso);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtFechaNacimiento);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(25, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 166);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Perro";
            // 
            // txtNroConsulta
            // 
            this.txtNroConsulta.Enabled = false;
            this.txtNroConsulta.Location = new System.Drawing.Point(141, 94);
            this.txtNroConsulta.Name = "txtNroConsulta";
            this.txtNroConsulta.Size = new System.Drawing.Size(133, 20);
            this.txtNroConsulta.TabIndex = 0;
            // 
            // txtRaza
            // 
            this.txtRaza.Enabled = false;
            this.txtRaza.Location = new System.Drawing.Point(411, 125);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(133, 20);
            this.txtRaza.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "N° Consulta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Raza";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(362, 581);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 45);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(271, 581);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 45);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(127, 18);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(133, 20);
            this.txtLegajo.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtLegajo);
            this.groupBox4.Location = new System.Drawing.Point(309, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 43);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Legajo";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(187, 581);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(64, 45);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminarMedicamento
            // 
            this.btnEliminarMedicamento.Enabled = false;
            this.btnEliminarMedicamento.Location = new System.Drawing.Point(146, 100);
            this.btnEliminarMedicamento.Name = "btnEliminarMedicamento";
            this.btnEliminarMedicamento.Size = new System.Drawing.Size(62, 24);
            this.btnEliminarMedicamento.TabIndex = 26;
            this.btnEliminarMedicamento.Text = "Eliminar";
            this.btnEliminarMedicamento.UseVisualStyleBackColor = true;
            this.btnEliminarMedicamento.Click += new System.EventHandler(this.btnEliminarMedicamento_Click);
            // 
            // btnEliminarSintoma
            // 
            this.btnEliminarSintoma.Enabled = false;
            this.btnEliminarSintoma.Location = new System.Drawing.Point(139, 100);
            this.btnEliminarSintoma.Name = "btnEliminarSintoma";
            this.btnEliminarSintoma.Size = new System.Drawing.Size(62, 24);
            this.btnEliminarSintoma.TabIndex = 27;
            this.btnEliminarSintoma.Text = "Eliminar";
            this.btnEliminarSintoma.UseVisualStyleBackColor = true;
            this.btnEliminarSintoma.Click += new System.EventHandler(this.btnEliminarSintoma_Click);
            // 
            // btnLimpiarSintomas
            // 
            this.btnLimpiarSintomas.Enabled = false;
            this.btnLimpiarSintomas.Location = new System.Drawing.Point(71, 100);
            this.btnLimpiarSintomas.Name = "btnLimpiarSintomas";
            this.btnLimpiarSintomas.Size = new System.Drawing.Size(62, 24);
            this.btnLimpiarSintomas.TabIndex = 30;
            this.btnLimpiarSintomas.Text = "Limpiar";
            this.btnLimpiarSintomas.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarMedicamentos
            // 
            this.btnLimpiarMedicamentos.Enabled = false;
            this.btnLimpiarMedicamentos.Location = new System.Drawing.Point(78, 100);
            this.btnLimpiarMedicamentos.Name = "btnLimpiarMedicamentos";
            this.btnLimpiarMedicamentos.Size = new System.Drawing.Size(62, 24);
            this.btnLimpiarMedicamentos.TabIndex = 31;
            this.btnLimpiarMedicamentos.Text = "Limpiar";
            this.btnLimpiarMedicamentos.UseVisualStyleBackColor = true;
            // 
            // ConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 649);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar consulta medica";
            this.Load += new System.EventHandler(this.ConsultaMedica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicamentos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSintomas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNroHC;
        private Label label3;
        private GroupBox groupBox1;
        private DataGridView grdMedicamentos;
        private GroupBox groupBox2;
        private DataGridView gdrSintomas;
        private Button btnBuscarMedicamentos;
        private Button btnBuscarSintomas;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtFechaNacimiento;
        private TextBox txtNombre;
        private TextBox txtDueño;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label label12;
        private GroupBox groupBox3;
        private Label label8;
        private TextBox txtRaza;
        private Button btnGuardar;
        private Button btnLimpiar;
        private DataGridViewTextBoxColumn Id_Medicamento;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label13;
        private TextBox txtNroConsulta;
        private ComboBox cmbMedicamentos;
        private Button btnAgregarM;
        private TextBox txtMedicamento;
        private ComboBox cmbSintomas;
        private Button btnAgregarSintomas;
        private TextBox txtSintoma;
        private TextBox txtLegajo;
        private GroupBox groupBox4;
        private Label label2;
        private Button btnVolver;
        private Button btnEliminarMedicamento;
        private Button btnLimpiarSintomas;
        private Button btnEliminarSintoma;
        private Button btnLimpiarMedicamentos;
    }
}