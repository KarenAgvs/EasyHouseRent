using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloProyectoFormativo
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txt1.Text;
            string email = txt3.Text;
            string direccion = txt4.Text;
            string telefono = txt5.Text;

            txt1.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
           

            MessageBox.Show("Señor(a) " + nombre + " la informacion fue enviada con exito, el propietario de la casa se comunicara con usted luego al telefono: " + telefono + " o al correo electronico: " + email + "   ¡GRACIAS POR USAR NUESTRO SERVICIO! ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Log = new Login();
            Log.ShowDialog();
            this.Close();
        }
    }
}
