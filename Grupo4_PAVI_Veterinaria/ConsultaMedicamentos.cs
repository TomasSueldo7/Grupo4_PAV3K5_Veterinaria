using Grupo4_PAVI_Veterinaria.Datos;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_PAVI_Veterinaria
{
    public partial class ConsultaMedicamentos : Form
    {
        private string fechaDesde;
        private string fechaHasta;

        public ConsultaMedicamentos()
        {
            InitializeComponent();
        }

        public ConsultaMedicamentos(string fechaDesde, string fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            InitializeComponent();
        }

        private void ConsultaMedicamentos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ConsultaMedicaBD.ObtenerListadoMedicamentos(fechaDesde, fechaHasta);

            ReportDataSource ds = new ReportDataSource("MedicamentosMasUsados", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
