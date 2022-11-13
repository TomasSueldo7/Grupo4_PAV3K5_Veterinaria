namespace Grupo4_PAVI_Veterinaria
{
    partial class ConsultaMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMedicamentos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proyectobasePAV1DataSet = new Grupo4_PAVI_Veterinaria.ProyectobasePAV1DataSet();
            this.proyectobasePAV1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proyectobasePAV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectobasePAV1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MedicamentosMasUsados";
            reportDataSource1.Value = this.proyectobasePAV1DataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Grupo4_PAVI_Veterinaria.ReporteMedicamentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // proyectobasePAV1DataSet
            // 
            this.proyectobasePAV1DataSet.DataSetName = "ProyectobasePAV1DataSet";
            this.proyectobasePAV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectobasePAV1DataSetBindingSource
            // 
            this.proyectobasePAV1DataSetBindingSource.DataSource = this.proyectobasePAV1DataSet;
            this.proyectobasePAV1DataSetBindingSource.Position = 0;
            // 
            // ConsultaMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Medicamentos";
            this.Load += new System.EventHandler(this.ConsultaMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectobasePAV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectobasePAV1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource proyectobasePAV1DataSetBindingSource;
        private ProyectobasePAV1DataSet proyectobasePAV1DataSet;
    }
}