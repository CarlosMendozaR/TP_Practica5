using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = 2018 - int.Parse(txtbEdad.Text);
                lbEdad.Text = "Tu edad es " + edad + " años.";
            }
            catch (FormatException error)
            {
                lbEdad.Text="Error: " + error.Message;
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

        }
    }
}
