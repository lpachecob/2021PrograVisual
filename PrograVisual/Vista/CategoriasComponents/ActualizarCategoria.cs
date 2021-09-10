using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PrograVisual.Controlador;
using System.Threading.Tasks;



namespace PrograVisual.Vista.CategoriasComponents
{
    public partial class ActualizarCategoria : PrograVisual.Vista.Layout
    {
        Database database = new Database();
        public string CategoryID;

        public ActualizarCategoria()
        {
            InitializeComponent();
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {

            string categoryName = TexboxNombreCategoria.Text;
            string categoryDescription = TexBoxDescripcionCategoria.Text;
            string categoryPicture = TextBoxImagenCategoria.Text;

            string sqlConsulta = "UPDATE Categories SET CategoryName = '" + categoryName + "', Description = '" + categoryDescription + "' WHERE CategoryID = " + CategoryID;
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
    }
}
