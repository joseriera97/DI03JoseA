using LibraryJose;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI03Jose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Evento que se lanza cuando se realiza click sobre el User Control.
            userImageProduct1.Click += new EventHandler(this.obtenerButton_Click);


        }


        protected void cambiarColorBoton(object sender, EventArgs e)
        {
            formPrincipalIdTextBox.Text += "id ";
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    formPrincipalIdTextBox.Text += "dentro de la comprobación";

                }
            }
                //No funciona
                string id = "";
                if (sender.GetType() == typeof(Button))
                {
                    Button botonClick = (Button)sender;

                    id = botonClick.Name;
                    formPrincipalIdTextBox.Text += "dentro de la comprobación" + id;
                }
                formPrincipalIdTextBox.Text += id + "id ";

            
        }

            //Cuando se realiza un click 
            //Este metodo esta puesto en todos los botones de Size
            public void obtenerButton_Click(object sender, EventArgs e)
            {
                cambiarColorBoton(sender, e);
            }

        }
    }

