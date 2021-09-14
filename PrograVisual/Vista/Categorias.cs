using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PrograVisual.Controlador;
using PrograVisual.Vista.CategoriasComponents;

namespace PrograVisual.Vista
{
    public partial class Categorias : PrograVisual.Vista.Layout
    {
        Database database = new Database();
        List<string> id = new List<string>();
        public Categorias()
        {
            InitializeComponent();
            Show();
            ListaCategorias.SelectedIndex = 0;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCategoria nuevaCategoria = new NuevaCategoria();

            nuevaCategoria.FormClosed += newCategoria_formClosed;
            nuevaCategoria.Show();
        }
        /** 
         * Muestra en el list box las categorias con su id y su nombre.
         */
        public void Show()
        {
            String sqlConsulta = "SELECT * FROM Categories";
            SqlCommand sqlComando = new SqlCommand(sqlConsulta, database.Conexion());
            SqlDataReader SqlRegistros = sqlComando.ExecuteReader();
            while (SqlRegistros.Read())
            {
                ListaCategorias.Items.Add(
                    "Id: " + SqlRegistros["CategoryID"] + 
                    " Cagtegoria: " + SqlRegistros["CategoryName"]);
            }
        }
        public void Update()
        {

            id = ListaCategorias.SelectedItem.ToString().Split(' ').ToList();
            ActualizarCategoria actualizarCategoria = new ActualizarCategoria();
            String sqlConsulta = "SELECT * FROM Categories WHERE CategoryID = " + id[1].ToString();
            SqlCommand sqlComando = new SqlCommand(sqlConsulta, database.Conexion());
            SqlDataReader SqlRegistros = sqlComando.ExecuteReader();
            while (SqlRegistros.Read())
            {
                actualizarCategoria.CategoryID = id[1].ToString();
                actualizarCategoria.TexboxNombreCategoria.Text = SqlRegistros["CategoryName"].ToString();
                actualizarCategoria.TexBoxDescripcionCategoria.Text = SqlRegistros["Description"].ToString();
            }
            actualizarCategoria.FormClosed += editCategoria_formClosed;
            actualizarCategoria.Show();
        }

        void editCategoria_formClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
            {
                id = ListaCategorias.SelectedItem.ToString().Split(' ').ToList();
                int ultimoIndex = int.Parse(id[1]) - 1;
                ListaCategorias.Items.Clear();
                InfoLabel.Text = "Datos actualizados correctamente.";
                Show();
                ListaCategorias.SelectedIndex = ultimoIndex;
            }
            else
            {
                InfoLabel.Text = "No se pudo ejecutar los cambios.";
            }
        }
        void newCategoria_formClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
            {
                id = ListaCategorias.SelectedItem.ToString().Split(' ').ToList();
                int ultimoIndex = int.Parse(id[1]) - 1;
                ListaCategorias.Items.Clear();
                InfoLabel.Text = "Categoria añadida correctamente.";
                Show();
                ListaCategorias.SelectedIndex = ultimoIndex;
            }
            else
            {
                InfoLabel.Text = "No se pudo ejecutar los cambios.";
            }
        }
    }
}
