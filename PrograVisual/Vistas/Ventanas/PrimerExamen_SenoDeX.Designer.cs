
namespace PrograVisual.Vistas.Ventanas
{
    partial class PrimerExamen_SenoDeX
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
            this.label5 = new System.Windows.Forms.Label();
            this.TexboxX = new System.Windows.Forms.TextBox();
            this.LabelResultado = new System.Windows.Forms.Label();
            this.Consola = new System.Windows.Forms.RichTextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hasklug Nerd Font Mono", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(162, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seno De X";
            // 
            // TexboxX
            // 
            this.TexboxX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.TexboxX.ForeColor = System.Drawing.SystemColors.Window;
            this.TexboxX.Location = new System.Drawing.Point(35, 141);
            this.TexboxX.Name = "TexboxX";
            this.TexboxX.Size = new System.Drawing.Size(258, 23);
            this.TexboxX.TabIndex = 1;
            this.TexboxX.Text = "Ingresar X";
            this.TexboxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelResultado
            // 
            this.LabelResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelResultado.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelResultado.Location = new System.Drawing.Point(123, 350);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.Size = new System.Drawing.Size(336, 59);
            this.LabelResultado.TabIndex = 12;
            this.LabelResultado.Text = "Ingrese Datos";
            this.LabelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Consola
            // 
            this.Consola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Consola.ForeColor = System.Drawing.SystemColors.Window;
            this.Consola.Location = new System.Drawing.Point(35, 196);
            this.Consola.Name = "Consola";
            this.Consola.Size = new System.Drawing.Size(505, 126);
            this.Consola.TabIndex = 13;
            this.Consola.Text = "";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(366, 120);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(174, 62);
            this.buttonCalcular.TabIndex = 14;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // PrimerExamen_SenoDeX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(576, 455);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.Consola);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.TexboxX);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrimerExamen_SenoDeX";
            this.Text = "PrimerExamen_SenoDeX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TexboxX;
        private System.Windows.Forms.Label LabelResultado;
        private System.Windows.Forms.RichTextBox Consola;
        private System.Windows.Forms.Button buttonCalcular;
    }
}