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
    public partial class Creacion_de_Reporte : Form
    {
        public Creacion_de_Reporte()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Creacion_de_Reporte_Load(object sender, EventArgs e)
        {
            cargarComboReporte();
        }

        private void cargarComboReporte()
        {
            cmbReporte.Items.Add("Consultas por Mes");
            cmbReporte.Items.Add("Consultas por Raza");
            cmbReporte.Items.Add("Consultas por Medicamento");
            cmbReporte.Items.Add("Listado de HC");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (txtDesde.Text != "" || txtHasta.Text != "")
            {
                crearReporte();
            }
            else
            {
                MessageBox.Show("Complete los campos de fechas para continuar");
            }
        }

        private void crearReporte()
        {
            String FechaDesde = txtDesde.Text;
            String FechaHasta = txtHasta.Text;
            if (cmbReporte.SelectedItem == "Consultas por Mes")
            {

                ConsultasXMes ventana = new ConsultasXMes(FechaDesde, FechaHasta);
                ventana.ShowDialog();

            }
            else if (cmbReporte.SelectedItem == "Consultas por Raza")
            {
                ConsultasPorRaza ventana = new ConsultasPorRaza(FechaDesde, FechaHasta);
                ventana.ShowDialog();
            }
            else if (cmbReporte.SelectedItem == "Consultas por Medicamento")
            {
                ConsultaMedicamentos ventana = new ConsultaMedicamentos(FechaDesde, FechaHasta);
                ventana.ShowDialog();
            }
            else if (cmbReporte.SelectedItem == "Listado de HC")
            {
                ListadoHC ventana = new ListadoHC(FechaDesde, FechaHasta);
                ventana.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
