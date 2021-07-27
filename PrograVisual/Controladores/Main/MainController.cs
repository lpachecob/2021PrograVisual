using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrograVisual.Vistas;
using System.Windows.Forms;


namespace PrograVisual.Controladores.Main
{
    class MainController
    {
        public void MainProyects(ListBox lista)
        {       
            lista.Items.Add("Mayor de cuatro numeros");
            lista.Items.Add("Operacion de dos numeros");
            lista.Items.Add("Mayor, menor y promedio de 100 numeros");
            lista.Items.Add("Cuanto cobrar por litros de agua");
            lista.Items.Add("Numero Perfecto");
        }

    }
}
