
namespace PrograVisual.Vista
{
    partial class Categorias
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListaCategorias = new System.Windows.Forms.ListBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(225, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorías";
            // 
            // ListaCategorias
            // 
            this.ListaCategorias.FormattingEnabled = true;
            this.ListaCategorias.Location = new System.Drawing.Point(12, 76);
            this.ListaCategorias.Name = "ListaCategorias";
            this.ListaCategorias.Size = new System.Drawing.Size(386, 264);
            this.ListaCategorias.TabIndex = 1;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(413, 76);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(177, 44);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(413, 128);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(177, 44);
            this.BtnActualizar.TabIndex = 3;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.InfoLabel.Location = new System.Drawing.Point(416, 293);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(177, 27);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(605, 363);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.ListaCategorias);
            this.Controls.Add(this.label1);
            this.Name = "Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnActualizar;
        public System.Windows.Forms.ListBox ListaCategorias;
        public System.Windows.Forms.Label InfoLabel;
    }
}
