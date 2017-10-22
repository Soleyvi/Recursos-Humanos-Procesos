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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Informacion = new Informacion();
        }

        private Informacion Informacion;
        private void button1_Click(object sender, EventArgs e)
        {
            Contratacion LLAMADA = new Contratacion();
            this.Hide();
            LLAMADA.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Planilla LLAMADA = new Planilla();
             this.Hide();
            LLAMADA.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reclutamiento LLAMADA = new Reclutamiento();
            this.Hide();
            LLAMADA.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En realidad desea salir ", "RECURSOS HUMANOS ", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            Application.Exit();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            texInformacion.Text = Convert.ToString(Informacion.InformacionRRHH());
           
        }
    }
}
