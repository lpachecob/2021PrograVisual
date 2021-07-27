
namespace PrograVisual.Vistas.Ventanas
{
    partial class FlitrosAgua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLitrosDeAgua = new System.Windows.Forms.TextBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.Consola = new System.Windows.Forms.RichTextBox();
            this.ListaCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLitrosDeAgua
            // 
            this.txtLitrosDeAgua.Location = new System.Drawing.Point(46, 101);
            this.txtLitrosDeAgua.Name = "txtLitrosDeAgua";
            this.txtLitrosDeAgua.Size = new System.Drawing.Size(220, 23);
            this.txtLitrosDeAgua.TabIndex = 0;
            this.txtLitrosDeAgua.Text = "0";
            this.txtLitrosDeAgua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(352, 89);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(181, 45);
            this.botonCalcular.TabIndex = 1;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // Consola
            // 
            this.Consola.Enabled = false;
            this.Consola.Location = new System.Drawing.Point(46, 250);
            this.Consola.Name = "Consola";
            this.Consola.Size = new System.Drawing.Size(487, 157);
            this.Consola.TabIndex = 2;
            this.Consola.Text = "";
            // 
            // ListaCategoria
            // 
            this.ListaCategoria.FormattingEnabled = true;
            this.ListaCategoria.Items.AddRange(new object[] {
            "Doméstico",
            "Comercial",
            "Industrial A",
            "Industrial B",
            "Institución estatal"});
            this.ListaCategoria.Location = new System.Drawing.Point(46, 171);
            this.ListaCategoria.Name = "ListaCategoria";
            this.ListaCategoria.Size = new System.Drawing.Size(487, 23);
            this.ListaCategoria.TabIndex = 3;
            // 
            // FlitrosAgua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(592, 494);
            this.Controls.Add(this.ListaCategoria);
            this.Controls.Add(this.Consola);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.txtLitrosDeAgua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlitrosAgua";
            this.Text = "FlitrosAgua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLitrosDeAgua;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.RichTextBox Consola;
        private System.Windows.Forms.ComboBox ListaCategoria;
    }
}