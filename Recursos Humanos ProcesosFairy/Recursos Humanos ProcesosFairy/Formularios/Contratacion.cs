using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursos_Humanos_ProcesosFairy.Formularios
{
    public partial class Contratacion : Form
    {
        public Contratacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En realidad desea salir ", "RECURSOS HUMANOS ", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            Application.Exit();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            Inicio LLAMADA = new Inicio();
            this.Hide();
            LLAMADA.ShowDialog();
        }
    }
}
