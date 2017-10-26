using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursos_Humanos_ProcesosFairy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceder_Click(object sender, EventArgs e)
        {
            if (texUsuario.Text == "RecursosHumanos"|| texContraseña.Text=="1304")

            {
                Recursos_Humanos_ProcesosFairy.Formularios.Inicio LLAMADA = new Formularios.Inicio();
                this.Hide();
                LLAMADA.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nombre o Contraseña Incorrectos ");
            }
        }



        private void checkBoxDescubrir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDescubrir.Checked==true)
            {
                texContraseña.UseSystemPasswordChar = false;

            }
            else
            {
                texContraseña.UseSystemPasswordChar = true;
            }


        }
    }
}
