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
    public partial class PrimerExamen_AreaTriangulo : Form
    {
        public PrimerExamen_AreaTriangulo()
        {
            InitializeComponent();
            ladoA = 0;
            ladoB = 0;
            ladoC = 0;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (TexboxLadoA.Text.All(char.IsDigit))
            {
                ladoA = double.Parse(TexboxLadoA.Text);
            }
            else { ladoA = 0; }
            if (TexboxLadoB.Text.All(char.IsDigit))
            {
                ladoB = double.Parse(TexboxLadoB.Text);
            }
            else { ladoA = 0; }
            if (TexboxLadoC.Text.All(char.IsDigit))
            {
                ladoC = double.Parse(TexboxLadoC.Text);
            }
            else { ladoA = 0; }

            p = (ladoA + ladoB + ladoC) / 2;

            Area = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
            LabelResultado.Text = "El area de los lados " + ladoA + " " + ladoB + " " + ladoC + " \r\nEs: " + Area;
        }

        double ladoA, ladoB, ladoC, p, Area;
    }
}
