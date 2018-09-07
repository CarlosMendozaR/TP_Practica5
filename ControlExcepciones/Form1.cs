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
            bool except1=false;
            do
            {
                except1 = false;

                try
                {
                    int edad = 2018 - int.Parse(txtbEdad.Text);
                    lbEdad.Text = "Tu edad es " + edad + " años.";
                    if (edad < 1 || edad > 119)
                    {
                        string error = "Error: El año que ingresaste no es válido.";
                        throw new ApplicationException(error);
                    }
                }
                catch (ApplicationException error)
                {
                    lbEdad.Text = error.Message;
                    except1 = true;
                }
                catch (FormatException error)
                {
                    lbEdad.Text = "Error: " + error.Message;
                    except1 = true;
                }
                catch
                {
                    lbEdad.Text = "Ups, parece que hubo un problema";
                    except1 = true;
                }
            }
            while (except1 == true);
            
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            bool except2 = false;
            do
            {

                except2 = false;

                try
                {

                    int divisor = (2018-int.Parse(txtbEdad.Text))/ int.Parse(txtbDivisor.Text);

                    lbDivision.Text = "La division es" + divisor;
                    if (divisor == 0)
                    {
                        string error = "No se puede dividir";
                        throw new ApplicationException(error);
                    }
                }
                catch (ApplicationException error)
                {
                    lbDivision.Text = error.Message;
                    except2 = true;
                }
                catch (FormatException error)
                {
                    lbDivision.Text = "Error" + error.Message;
                    except2 = true;
                }
                catch
                {
                    lbDivision.Text = "Ups, parece que hubo un problema";
                    except2 = true;
                }
            }
            while (except2 == true);
            

        }
    }
}
