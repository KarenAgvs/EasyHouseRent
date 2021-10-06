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
    public partial class Casa3 : Form
    {
        public Casa3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formulario Form = new Formulario();
            Form.ShowDialog();
            this.Close();
        }
    }
}
