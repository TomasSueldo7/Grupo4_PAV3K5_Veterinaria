using Grupo4_PAVI_Veterinaria.Datos;
using Grupo4_PAVI_Veterinaria.formularios;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario y contraseña");
            }
            else
            {
                string nombreDeUsuario = txtUsuario.Text;
                string contra = txtPassword.Text;
                bool resultado = false;
                try
                {

                    resultado = UsuariosBD.ValidarUsuario(nombreDeUsuario, contra);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al consultar el usuario");
                }

                if (resultado)
                {
                    PrincipalForm ventana = new PrincipalForm(nombreDeUsuario, contra);
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario Inexistente");
                }
            }
        }
    }
}
