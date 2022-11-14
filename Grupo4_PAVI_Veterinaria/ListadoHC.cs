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
    public partial class ListadoHC : Form
    {
        private string fechaDesde;
        private string fechaHasta;

        public ListadoHC()
        {
            InitializeComponent();
        }

        public ListadoHC(string fechaDesde, string fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            InitializeComponent();
        }

        private void ListadoHC_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = ConsultaMedicaBD.ObtenerListadoHC(fechaDesde, fechaHasta);

            ReportDataSource ds = new ReportDataSource("DatosListadoHC", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            txtFilas.Text = "Filas recuperadas: " + tabla.Rows.Count.ToString();
        }
    }
}
