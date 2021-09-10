using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograVisual.Vista
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            MainProyects();
        }

        public void abrirFormulario(object formulario)
        {
            if (this.WindowApp.Controls.Count > 0) { this.WindowApp.Controls.RemoveAt(0); }
            Form formularioHijo = formulario as Form;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.WindowApp.Controls.Add(formularioHijo);
            this.WindowApp.Tag = formularioHijo;
            formularioHijo.Show();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            abrirFormulario(new VentanaInicio());
        }

        private void Start_Click(object sender, EventArgs e)
        {
            abrirFormulario(new VentanaInicio());
        }

        private void ListaApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaApp.SelectedItem != null)
            {
                switch (ListaApp.SelectedItem.ToString())
                {
                    case "Productos":
                        abrirFormulario(new Productos());
                        break;
                    case "Categorias":
                        abrirFormulario(new Categorias());
                        break;
                    default:
                        abrirFormulario(new VentanaInicio());
                        break;
                }
            }
        }
        public void MainProyects()
        {
            ListaApp.Items.Add("Productos");
            ListaApp.Items.Add("Categorias");
        }
    }
}
