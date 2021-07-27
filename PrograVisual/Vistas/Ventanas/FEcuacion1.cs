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
    public partial class FEcuacion1 : Form
    {
        public FEcuacion1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double CoeficienteA, CoeficienteB, Resultado;

            CoeficienteA = Double.Parse(textBoxCoefA.Text);
            CoeficienteB = Double.Parse(textBoxCoefB.Text);

            Resultado = -CoeficienteA / CoeficienteB;

            LabelResultado.Text = ""+Resultado+"";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxCoefA.Text = "";
            textBoxCoefB.Text = "";
            LabelResultado.Text = "Ingrese Datos";
        }
    }
}
