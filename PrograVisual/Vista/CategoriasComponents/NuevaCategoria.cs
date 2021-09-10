using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using PrograVisual.Controlador;

namespace PrograVisual.Vista.CategoriasComponents
{
    public partial class NuevaCategoria : PrograVisual.Vista.Layout
    {
        Database database = new Database();

        public NuevaCategoria()
        {
            InitializeComponent();
        }

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            string categoryName = TexboxNombreCategoria.Text;
            string categoryDescription = TexBoxDescripcionCategoria.Text;
            string categoryPicture = TextBoxImagenCategoria.Text;

            string sqlConsulta = "INSERT INTO Categories (CategoryName,Description) VALUES ('" + categoryName + "','" + categoryDescription + "');";
            SqlCommand sqlComando = new SqlCommand(sqlConsulta, database.Conexion());
            int filasAfectadas = sqlComando.ExecuteNonQuery();
            if (filasAfectadas == 1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No existe un artículo con el código ingresado");
            }
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
