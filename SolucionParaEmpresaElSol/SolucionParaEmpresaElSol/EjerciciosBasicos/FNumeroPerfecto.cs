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
    public partial class FNumeroPerfecto : Form
    {
        public FNumeroPerfecto()
        {
            InitializeComponent();

            this.ActiveControl = Numero;
        }

        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            int contador = 0, numero = 0;

            if (Numero.Text != string.Empty)
            {
                numero = int.Parse(Numero.Text);
            }

            for (int iterador = 1; iterador < numero; iterador++)
            {
                if (numero % iterador == 0)
                {
                    contador += iterador;
                }
            }

            if (contador == numero)
            {
                Consola.AppendText("> " + numero + " Es un número perfecto" + System.Environment.NewLine);
            }
            else
            {
                Consola.AppendText("> " + numero + " No es un número perfecto" + System.Environment.NewLine);
            }
            this.ActiveControl = Numero;
        }
    }
}
