using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionParaEmpresaElSol.EjerciciosBasicos
{
    public partial class FEstadisticas : Form
    {
        public FEstadisticas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Numeros = new int[4];

            if (textBoxNumero1.Text == string.Empty)
            {
                Numeros[0] = 0;
            }
            else
            {
                Numeros[0] = int.Parse(textBoxNumero1.Text);
            }
            
            if (textBoxNumero2.Text == string.Empty)
            {
                Numeros[1] = 0;
            }
            else
            {
                Numeros[1] = int.Parse(textBoxNumero2.Text);
            }

            if (textBoxNumero3.Text == string.Empty)
            {
                Numeros[2] = 0;
            }
            else
            {
                Numeros[2] = int.Parse(textBoxNumero3.Text);
            }

            if (textBoxNumero4.Text == string.Empty)
            {
                Numeros[3] = 0;
            }
            else
            {
                Numeros[3] = int.Parse(textBoxNumero4.Text);
            }

            int NumeroMaximo = Numeros[0], NumeroMinimo = Numeros[0];

            for (int iterador = 0; iterador < Numeros.Length; iterador++)
            {
                if (Numeros[iterador] > NumeroMaximo)
                {
                    NumeroMaximo = Numeros[iterador];
                }
                else if (Numeros[iterador] < NumeroMinimo)
                {
                    NumeroMinimo = Numeros[iterador];
                }
            }

            LabelResultado.Text =
                "El Mayor de los Números es: " + NumeroMaximo + Environment.NewLine +
                "El Menor de los Números es: " + NumeroMinimo;
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            LabelResultado.Text = "Ingresar Datos";
            textBoxNumero1.Text = "0";
            textBoxNumero2.Text = "0";
            textBoxNumero3.Text = "0";
            textBoxNumero4.Text = "0";
        }
    }
}
