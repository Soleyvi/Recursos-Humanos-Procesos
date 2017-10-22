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
            if (this.texUsuario.Text == "Recursos Humanos" || this.texUsuario.Text == "contraseña") ;
            {
                Recursos_Humanos_ProcesosFairy.Formularios.Inicio llamada = new Formularios.Inicio();
                this.Hide();
                llamada.ShowDialog();
              
            }
        }
    }
}
