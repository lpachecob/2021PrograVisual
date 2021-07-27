using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrograVisual.Controladores.Main;
using System.Runtime.InteropServices;
using PrograVisual.Vistas.Ventanas;

namespace PrograVisual.Vistas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ListaDeProyectos.ItemHeight = 20;
            mainController.MainProyects(ListaDeProyectos);
            abrirFormulario(new Inicio());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        MainController mainController = new MainController();

        private void ListaDeProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ListaDeProyectos.SelectedIndex)
            {
                case 0:
                    abrirFormulario(new FEstadisticas());
                    break;
                case 1:
                    abrirFormulario(new FEcuacion1());
                    break;
                case 2:
                    abrirFormulario(new FControlListbox());
                    break;
                case 3:
                    abrirFormulario(new FlitrosAgua());
                    break;
                case 4:
                    abrirFormulario(new FNumeroPerfecto());
                    break;
                default:
                    abrirFormulario(new Inicio());
                    break;
            }
        }

        private void abrirFormulario(object formulario)
        {
            if (this.Container.Controls.Count > 0) { this.Container.Controls.RemoveAt(0); }
            Form formularioHijo = formulario as Form;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.Container.Controls.Add(formularioHijo);
            this.Container.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Inicio());
        }
    }
}
