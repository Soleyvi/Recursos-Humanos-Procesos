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
    public partial class Reclutamiento : Form
    {
        public Reclutamiento()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           /* txtNombres.Focus();
            Nuevo = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;*/
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /* // Cuando hago click en el botón Nuevo que proceda la inserción de un registro en la Base de Datos.
             if (Nuevo)
             {
                 string sql = "INSERT INTO Personas (IdPersona, Apellido, Nombre, Direccion, Ciudad)"
                           + "VALUES ('" + txtID.Text + "', '" +
                                      txtApellidos.Text + "', '" +
                                      txtNombres.Text + "', '" +
                                      txtDireccion.Text + "', '" +
                                      txtPuestoAplicar.Text + "')";


                 SqlCommand cmd = new SqlCommand(sql, objConexion.sqlCon);
                 cmd.CommandType = CommandType.Text;

                 try
                 {
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Registro ingresado correctamente !");
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error: " + ex.ToString());
                 }
                 /*finally
                 {
                     // Cierro la Conexión.
                     objConexion.sqlCon.Close();
                 }*/
                /* btnNuevo.Enabled = true;
                 btnGuardar.Enabled = false; */

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          /*  if (txtID.Text != "")
            {

                string sql = "DELETE FROM Personas WHERE IdPersona=" + txtID.Text;

                SqlCommand cmd = new SqlCommand(sql, objConexion.sqlCon);
                cmd.CommandType = CommandType.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado correctamente !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un codigo para eliminar el registro");
                txtID.Focus();
            }*/
        }

      /*  private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "select Apellido, Nombre, Direccion, puesto from Personas where IdPersona=" + txtID.Text;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En realidad desea salir ", "RECURSOS HUMANOS ", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            Application.Exit();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            Inicio LLAMADA = new Inicio();
            this.Hide();
            LLAMADA.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recursos_Humanos_ProcesosFairy.Formularios.Contratacion llamada = new Contratacion();
            this.Hide();
            llamada.ShowDialog();
        } 
    }
}
