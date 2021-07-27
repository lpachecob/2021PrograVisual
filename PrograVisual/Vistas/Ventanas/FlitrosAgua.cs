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
    public partial class FlitrosAgua : Form
    {
        double CantidadLitros, total;
        int CategoriaElegida;
        string CategoriaElegidaText;
        public FlitrosAgua()
        {
            InitializeComponent();
            ListaCategoria.SelectedIndex = 0;
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtLitrosDeAgua.Text))
            {
                CantidadLitros = 0;
            }
            else
            {
                CantidadLitros = double.Parse(txtLitrosDeAgua.Text);
            }

            CategoriaElegida = ListaCategoria.SelectedIndex;
            CategoriaElegidaText = ListaCategoria.SelectedItem.ToString();
            
            switch (CategoriaElegida)
            {
                case 0:
                    total = CantidadLitros * 0.10;
                    Consola.AppendText("Categoria :" + CategoriaElegidaText + System.Environment.NewLine);
                    Consola.AppendText("Monto a Pagar S/.: " + total + System.Environment.NewLine);
                    break;
                case 1:
                    total = CantidadLitros * 0.20;
                    Consola.AppendText("Categoria : " + CategoriaElegidaText + System.Environment.NewLine);
                    Consola.AppendText("Monto a Pagar S/.: " + total + System.Environment.NewLine);
                    break;
                case 2:
                    total = CantidadLitros * 0.25;
                    Consola.AppendText("Categoria : " + CategoriaElegidaText + System.Environment.NewLine);
                    Consola.AppendText("Monto a Pagar S/.: " + total + System.Environment.NewLine);
                    break;
                case 3:
                    total = CantidadLitros * 0.30;
                    Consola.AppendText("Categoria : " + CategoriaElegidaText + System.Environment.NewLine);
                    Consola.AppendText("Monto a Pagar S/.: " + total + System.Environment.NewLine);
                    break;
                case 4:
                    total = CantidadLitros * 0.15;
                    Consola.AppendText("Categoria : " + CategoriaElegidaText + System.Environment.NewLine);
                    Consola.AppendText("Monto a Pagar S/.: " + total + System.Environment.NewLine);
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }
    }
}
