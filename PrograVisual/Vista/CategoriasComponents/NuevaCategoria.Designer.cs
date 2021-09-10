
namespace PrograVisual.Vista.CategoriasComponents
{
    partial class NuevaCategoria
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
            this.BotonCrear = new System.Windows.Forms.Button();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.TextBoxImagenCategoria = new System.Windows.Forms.TextBox();
            this.TexBoxDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.TexboxNombreCategoria = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonCrear
            // 
            this.BotonCrear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BotonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCrear.ForeColor = System.Drawing.SystemColors.Window;
            this.BotonCrear.Location = new System.Drawing.Point(430, 147);
            this.BotonCrear.Name = "BotonCrear";
            this.BotonCrear.Size = new System.Drawing.Size(148, 101);
            this.BotonCrear.TabIndex = 20;
            this.BotonCrear.Text = "Crear";
            this.BotonCrear.UseVisualStyleBackColor = false;
            this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.BackColor = System.Drawing.Color.Firebrick;
            this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrar.ForeColor = System.Drawing.Color.White;
            this.BotonCerrar.Location = new System.Drawing.Point(430, 318);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(148, 39);
            this.BotonCerrar.TabIndex = 19;
            this.BotonCerrar.Text = "Cancelar";
            this.BotonCerrar.UseVisualStyleBackColor = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // TextBoxImagenCategoria
            // 
            this.TextBoxImagenCategoria.Location = new System.Drawing.Point(47, 256);
            this.TextBoxImagenCategoria.Name = "TextBoxImagenCategoria";
            this.TextBoxImagenCategoria.Size = new System.Drawing.Size(316, 20);
            this.TextBoxImagenCategoria.TabIndex = 18;
            // 
            // TexBoxDescripcionCategoria
            // 
            this.TexBoxDescripcionCategoria.Location = new System.Drawing.Point(47, 195);
            this.TexBoxDescripcionCategoria.Name = "TexBoxDescripcionCategoria";
            this.TexBoxDescripcionCategoria.Size = new System.Drawing.Size(316, 20);
            this.TexBoxDescripcionCategoria.TabIndex = 17;
            // 
            // TexboxNombreCategoria
            // 
            this.TexboxNombreCategoria.Location = new System.Drawing.Point(47, 136);
            this.TexboxNombreCategoria.Multiline = true;
            this.TexboxNombreCategoria.Name = "TexboxNombreCategoria";
            this.TexboxNombreCategoria.Size = new System.Drawing.Size(316, 20);
            this.TexboxNombreCategoria.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-9, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 4);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(44, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Imagen de categoría";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(44, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripción de categoría";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.labelNombre.Location = new System.Drawing.Point(44, 120);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(108, 13);
            this.labelNombre.TabIndex = 12;
            this.labelNombre.Text = "Nombre de categoría";
            // 
            // Titulo
            // 
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Titulo.ForeColor = System.Drawing.SystemColors.Window;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(605, 75);
            this.Titulo.TabIndex = 11;
            this.Titulo.Text = "Nueva Categoria";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NuevaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(605, 363);
            this.Controls.Add(this.BotonCrear);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.TextBoxImagenCategoria);
            this.Controls.Add(this.TexBoxDescripcionCategoria);
            this.Controls.Add(this.TexboxNombreCategoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.Titulo);
            this.Name = "NuevaCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonCrear;
        private System.Windows.Forms.Button BotonCerrar;
        public System.Windows.Forms.TextBox TextBoxImagenCategoria;
        public System.Windows.Forms.TextBox TexBoxDescripcionCategoria;
        public System.Windows.Forms.TextBox TexboxNombreCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNombre;
        public System.Windows.Forms.Label Titulo;
    }
}
