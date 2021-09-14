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


namespace PrograVisual.Vista
{
    public partial class Productos : PrograVisual.Vista.Layout
    {
        Database database = new Database();
        List<string> id = new List<string>();
        bool Actualizar;
        bool Nuevo;

        public Productos()
        {
            InitializeComponent();
            Actualizar = false;
            Nuevo = false;
            ListarProductos();
        }


        private void TextBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (TextBusqueda.Text == string.Empty)
            {
                ListarProductos();
            }
            else
            {
                ListarProductos(TextBusqueda.Text);
            }


        }
        private void ListaProductos_DoubleClick(object sender, EventArgs e)
        {
            cambiarEstadoElementos();
            BotonConfirmacion.Text = "Actualizar";
            Actualizar = true;

            id = ListaProductos.SelectedItem.ToString().Split(' ').ToList();

            String sqlConsulta = "SELECT * FROM Products INNER JOIN Categories on Categories.CategoryID=Products.CategoryID INNER JOIN Suppliers ON Suppliers.SupplierID=Products.SupplierID WHERE Discontinued = 0 AND ProductID = '" + id[1] + "'";

            SqlCommand sqlComando = new SqlCommand(sqlConsulta, database.Conexion());
            SqlDataReader SqlRegistros = sqlComando.ExecuteReader();
            while (SqlRegistros.Read())
            {
                TextBusqueda.Text = SqlRegistros["ProductID"] + "";
                TextProductName.Text = SqlRegistros["ProductName"] + "";
                ComboCategorias.Items.Add("" + SqlRegistros["CategoryID"] + " - " + SqlRegistros["CategoryName"]);
                ComboProveedores.Items.Add("" + SqlRegistros["SupplierID"] + " - " + SqlRegistros["CompanyName"]);
                TextCantidadesUnidad.Text = SqlRegistros["QuantityPerUnit"] + "";
                TextPrecioUnitario.Text = SqlRegistros["UnitPrice"] + "";
                TextUnidadesStock.Text = SqlRegistros["UnitsInStock"] + "";
                TextUnidadesOrdenadas.Text = SqlRegistros["UnitsOnOrder"] + "";
                TextReorderLevel.Text = SqlRegistros["ReorderLevel"] + "";
            }
            ComboCategorias.SelectedIndex = 0;
            ComboProveedores.SelectedIndex = 0;

            sqlConsulta = "SELECT CategoryID,CategoryName FROM Categories ORDER BY CategoryID ASC";

            sqlComando = new SqlCommand(sqlConsulta, database.Conexion());
            SqlRegistros = sqlComando.ExecuteReader();
            while (SqlRegistros.Read())
            {
                ComboCategorias.Items.Add("" + SqlRegistros["CategoryID"] + " - " + SqlRegistros["CategoryName"]);
            }
            sqlConsulta = "SELECT SupplierID,CompanyName FROM Suppliers ORDER BY SupplierID ASC";

            sqlComando = new SqlCommand(sqlConsulta, database.Conexion());
            SqlRegistros = sqlComando.ExecuteReader();
            while (SqlRegistros.Read())
            {
                ComboProveedores.Items.Add("" + SqlRegistros["SupplierID"] + " - " + SqlRegistros["CompanyName"]);
            }
        }

        public void ListarProductos(string productID = null)
        {
            String sqlConsulta;
            ListaProductos.Items.Clear();
            if (productID != null)
            {
                sqlConsulta = "SELECT * FROM Products WHERE Discontinued = 0 AND (ProductID like '%" + productID + "%' OR ProductName like '%" + productID + "%' )";
            }
            else
            {
                sqlConsulta = "SELECT * FROM Products WHERE Discontinued = 0";
            }
            SqlCommand sqlComando = new SqlCommand(sqlConsulta, database.Conexion());
            SqlDataReader SqlRegistros = sqlComando.ExecuteReader();
            while (SqlRegistros.Read())
            {
                ListaProductos.Items.Add(
                    "Id: " + SqlRegistros["ProductID"] +
                    " Producto: " + SqlRegistros["ProductName"]);
            }
        }



        public void cambiarEstadoElementos()
        {
            ListaProductos.Visible = !ListaProductos.Visible;
            TextBusqueda.Visible = !TextBusqueda.Visible;
            label3.Visible = !label3.Visible;
            label4.Visible = !label4.Visible;
            label5.Visible = !label5.Visible;
            label6.Visible = !label6.Visible;
            label7.Visible = !label7.Visible;
            label8.Visible = !label8.Visible;
            label9.Visible = !label9.Visible;
            label10.Visible = !label10.Visible;
            TextProductName.Visible = !TextProductName.Visible;
            ComboCategorias.Visible = !ComboCategorias.Visible;
            ComboProveedores.Visible = !ComboProveedores.Visible;
            TextCantidadesUnidad.Visible = !TextCantidadesUnidad.Visible;
            TextPrecioUnitario.Visible = !TextPrecioUnitario.Visible;
            TextUnidadesStock.Visible = !TextUnidadesStock.Visible;
            TextUnidadesOrdenadas.Visible = !TextUnidadesOrdenadas.Visible;
            TextReorderLevel.Visible = !TextReorderLevel.Visible;
            BotonCancelar.Visible = !BotonCancelar.Visible;
            BotonConfirmacion.Visible = !BotonConfirmacion.Visible;
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            cambiarEstadoElementos();
            BotonConfirmacion.Text = "";
            TextBusqueda.Text = "";
        }

        private void BotonConfirmacion_Click(object sender, EventArgs e)
        {
            if (Actualizar)
            {
                string textId = TextBusqueda.Text;
                string textNombreProducto = TextProductName.Text;
                List<string> textCategoria = ComboCategorias.SelectedItem.ToString().Split(' ').ToList();
                List<string> textProveedores = ComboProveedores.SelectedItem.ToString().Split(' ').ToList();
                string textCantidadUnidades = TextCantidadesUnidad.Text;
                string textPrecioUnitario = TextPrecioUnitario.Text;
                string textUnidadesStock = TextUnidadesStock.Text;
                string textUnidadesOrdenadas = TextUnidadesOrdenadas.Text;
                string textReorderLevel = TextReorderLevel.Text;

                String sqlConsulta = "UPDATE Products SET" +
                    "Productname = '" + textNombreProducto + "'," +
                    "SupplierID = '" + textProveedores[0] + "'," +
                    "CategoryID = '" + textCategoria[0] + "'," +
                    "QuantityPerUnit = '" + textCantidadUnidades + "'," +
                    "UnitPrice = '" + textPrecioUnitario + "'," +
                    "UnitsInStock = '" + textUnidadesStock + "'," +
                    "UnitsOnOrder = '" + textUnidadesOrdenadas + "'," +
                    "ReorderLevel = '" + textReorderLevel + "'" +
                    "WHERE ProductID = '" + textId + "'";

                SqlCommand sqlComando = new SqlCommand(sqlConsulta, database.Conexion());
                int filasAfectadas = sqlComando.ExecuteNonQuery();
                if (filasAfectadas == 1)
                {
                    MessageBox.Show("echo");
                }
                else
                {
                    MessageBox.Show("No existe un artículo con el código ingresado");
                }
                Actualizar = false;
                cambiarEstadoElementos();
                BotonConfirmacion.Text = "";
                TextBusqueda.Text = "";
            }
        }
    }
}
