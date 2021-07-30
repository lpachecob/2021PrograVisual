using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograVisual.Vistas.Ventanas
{
    public partial class PrimerExamen_SenoDeX : Form
    {
        public PrimerExamen_SenoDeX()
        {
            InitializeComponent();
            cantidadTerminos = 17;
            factorial = 1;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            x = int.Parse(TexboxX.Text);
            s = x;

            for (int i = 2; i < cantidadTerminos; i++)
            {
                factorial = factorial * ((i * 2) - 2) * ((i * 2) - 1);

                if (i % 2 == 0)
                {
                    s = s - Math.Pow(x, i * 2 - 1) / factorial;
                    Consola.AppendText(">" + s + "\r\n");
                }
                else
                {
                    s = s + Math.Pow(x, i * 2 - 1) / factorial;
                    Consola.AppendText(">" + s + "\r\n");
                }
            }

            LabelResultado.Text = "El Seno de: " + x + " es: " + string.Format("{0:0.00}", s);

        }



        int x, cantidadTerminos, factorial;
        double s;
    }
}
