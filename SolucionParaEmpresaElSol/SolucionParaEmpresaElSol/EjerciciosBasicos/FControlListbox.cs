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
    public partial class FControlListbox : Form
    {
        public FControlListbox()
        {
            InitializeComponent();

            int[] Numeros = new int[100];
            int NumeroMaximo;
            int NumeroMinimo;
            int aux = 0;
            int sumatotal = 0;
            int promedio = 0;

            //Generar números aleatorios
            var patron = Environment.TickCount;
            var aleatoreo = new Random(patron);

            for (int iterador = 0; iterador < 100; iterador++)
            {
                int value = aleatoreo.Next(0, 1000);
                Consola.Items.Add("Número " + iterador + ": " + value);

                Numeros[iterador] = value;

            }

            NumeroMaximo = Numeros[0];
            NumeroMinimo = Numeros[0];

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



            for (int iterador = 0; iterador < Numeros.Length; iterador++)
            {
                sumatotal += Numeros[iterador];
            }

            promedio = sumatotal / Numeros.Length;


            texbox_NumeroMayor.Text = "" + NumeroMaximo;
            texbox_NumeroMenor.Text = "" + NumeroMinimo;
            texbox_Promedio.Text = "" + promedio;
        }
    }
}
