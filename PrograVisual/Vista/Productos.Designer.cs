
namespace PrograVisual.Vista
{
    partial class Productos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaProductos = new System.Windows.Forms.ListBox();
            this.TextBusqueda = new System.Windows.Forms.TextBox();
            this.northwindDataSet = new PrograVisual.NorthwindDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new PrograVisual.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.TextProductName = new System.Windows.Forms.TextBox();
            this.ComboProveedores = new System.Windows.Forms.ComboBox();
            this.ComboCategorias = new System.Windows.Forms.ComboBox();
            this.TextCantidadesUnidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextUnidadesStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextUnidadesOrdenadas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextReorderLevel = new System.Windows.Forms.TextBox();
            this.BotonConfirmacion = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.BotonNuevoProducto = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TooltipListaProductos = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // ListaProductos
            // 
            this.ListaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListaProductos.FormattingEnabled = true;
            this.ListaProductos.Location = new System.Drawing.Point(12, 90);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(408, 225);
            this.ListaProductos.TabIndex = 1;
            this.ListaProductos.Click += new System.EventHandler(this.ListaProductos_Click);
            this.ListaProductos.DoubleClick += new System.EventHandler(this.ListaProductos_DoubleClick);
            // 
            // TextBusqueda
            // 
            this.TextBusqueda.Location = new System.Drawing.Point(79, 54);
            this.TextBusqueda.Name = "TextBusqueda";
            this.TextBusqueda.Size = new System.Drawing.Size(341, 20);
            this.TextBusqueda.TabIndex = 1;
            this.TextBusqueda.Click += new System.EventHandler(this.TextBusqueda_Click);
            this.TextBusqueda.TextChanged += new System.EventHandler(this.TextBusqueda_TextChanged);
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northwindDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // TextProductName
            // 
            this.TextProductName.Location = new System.Drawing.Point(12, 106);
            this.TextProductName.Name = "TextProductName";
            this.TextProductName.Size = new System.Drawing.Size(315, 20);
            this.TextProductName.TabIndex = 2;
            this.TextProductName.Visible = false;
            // 
            // ComboProveedores
            // 
            this.ComboProveedores.FormattingEnabled = true;
            this.ComboProveedores.Location = new System.Drawing.Point(12, 151);
            this.ComboProveedores.Name = "ComboProveedores";
            this.ComboProveedores.Size = new System.Drawing.Size(146, 21);
            this.ComboProveedores.TabIndex = 4;
            this.ComboProveedores.Visible = false;
            // 
            // ComboCategorias
            // 
            this.ComboCategorias.FormattingEnabled = true;
            this.ComboCategorias.Location = new System.Drawing.Point(333, 105);
            this.ComboCategorias.Name = "ComboCategorias";
            this.ComboCategorias.Size = new System.Drawing.Size(149, 21);
            this.ComboCategorias.TabIndex = 3;
            this.ComboCategorias.Visible = false;
            // 
            // TextCantidadesUnidad
            // 
            this.TextCantidadesUnidad.Location = new System.Drawing.Point(12, 199);
            this.TextCantidadesUnidad.Name = "TextCantidadesUnidad";
            this.TextCantidadesUnidad.Size = new System.Drawing.Size(146, 20);
            this.TextCantidadesUnidad.TabIndex = 5;
            this.TextCantidadesUnidad.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del Producto";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Proveedor";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(330, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoría";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad por Unidad";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(164, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio Unitario";
            this.label7.Visible = false;
            // 
            // TextPrecioUnitario
            // 
            this.TextPrecioUnitario.Location = new System.Drawing.Point(164, 199);
            this.TextPrecioUnitario.Name = "TextPrecioUnitario";
            this.TextPrecioUnitario.Size = new System.Drawing.Size(146, 20);
            this.TextPrecioUnitario.TabIndex = 6;
            this.TextPrecioUnitario.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(316, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Unidades en Stock";
            this.label8.Visible = false;
            // 
            // TextUnidadesStock
            // 
            this.TextUnidadesStock.Location = new System.Drawing.Point(316, 199);
            this.TextUnidadesStock.Name = "TextUnidadesStock";
            this.TextUnidadesStock.Size = new System.Drawing.Size(146, 20);
            this.TextUnidadesStock.TabIndex = 7;
            this.TextUnidadesStock.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(12, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Unidades Ordenadas";
            this.label9.Visible = false;
            // 
            // TextUnidadesOrdenadas
            // 
            this.TextUnidadesOrdenadas.Location = new System.Drawing.Point(12, 260);
            this.TextUnidadesOrdenadas.Name = "TextUnidadesOrdenadas";
            this.TextUnidadesOrdenadas.Size = new System.Drawing.Size(146, 20);
            this.TextUnidadesOrdenadas.TabIndex = 7;
            this.TextUnidadesOrdenadas.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(167, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Reorder Level";
            this.label10.Visible = false;
            // 
            // TextReorderLevel
            // 
            this.TextReorderLevel.Location = new System.Drawing.Point(167, 260);
            this.TextReorderLevel.Name = "TextReorderLevel";
            this.TextReorderLevel.Size = new System.Drawing.Size(146, 20);
            this.TextReorderLevel.TabIndex = 8;
            this.TextReorderLevel.Visible = false;
            // 
            // BotonConfirmacion
            // 
            this.BotonConfirmacion.Location = new System.Drawing.Point(478, 294);
            this.BotonConfirmacion.Name = "BotonConfirmacion";
            this.BotonConfirmacion.Size = new System.Drawing.Size(115, 32);
            this.BotonConfirmacion.TabIndex = 9;
            this.BotonConfirmacion.UseVisualStyleBackColor = true;
            this.BotonConfirmacion.Visible = false;
            this.BotonConfirmacion.Click += new System.EventHandler(this.BotonConfirmacion_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(357, 294);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(115, 32);
            this.BotonCancelar.TabIndex = 10;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Visible = false;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // LabelInfo
            // 
            this.LabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelInfo.Location = new System.Drawing.Point(354, 331);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(239, 25);
            this.LabelInfo.TabIndex = 22;
            this.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotonNuevoProducto
            // 
            this.BotonNuevoProducto.Location = new System.Drawing.Point(446, 90);
            this.BotonNuevoProducto.Name = "BotonNuevoProducto";
            this.BotonNuevoProducto.Size = new System.Drawing.Size(133, 36);
            this.BotonNuevoProducto.TabIndex = 2;
            this.BotonNuevoProducto.Text = "Nuevo Producto";
            this.BotonNuevoProducto.UseVisualStyleBackColor = true;
            this.BotonNuevoProducto.Click += new System.EventHandler(this.BotonNuevoProducto_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(12, 295);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(133, 36);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Visible = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(15, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Buscar";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(605, 363);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BotonNuevoProducto);
            this.Controls.Add(this.LabelInfo);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonConfirmacion);
            this.Controls.Add(this.ListaProductos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextReorderLevel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextUnidadesOrdenadas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextUnidadesStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextPrecioUnitario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextCantidadesUnidad);
            this.Controls.Add(this.ComboCategorias);
            this.Controls.Add(this.ComboProveedores);
            this.Controls.Add(this.TextProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListaProductos;
        private System.Windows.Forms.TextBox TextBusqueda;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextProductName;
        private System.Windows.Forms.ComboBox ComboProveedores;
        private System.Windows.Forms.ComboBox ComboCategorias;
        private System.Windows.Forms.TextBox TextCantidadesUnidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextPrecioUnitario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextUnidadesStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextUnidadesOrdenadas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextReorderLevel;
        private System.Windows.Forms.Button BotonConfirmacion;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Button BotonNuevoProducto;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.ToolTip TooltipListaProductos;
        private System.Windows.Forms.Label label11;
    }
}
