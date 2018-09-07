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
                if (edad<1||edad>119)
                {
                    string error = "Error: El año que ingresaste no es válido.";
                    throw new ApplicationException(error);
                }
            }
            catch (ApplicationException error)
            {
                lbEdad.Text = error.Message;
            }
            catch (FormatException error)
            {
                lbEdad.Text="Error: " + error.Message;
            }
            catch
            {
                lbEdad.Text = "Ups, parece que hubo un problema";
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {

        }
    }
}
