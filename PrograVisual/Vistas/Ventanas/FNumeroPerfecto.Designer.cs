
namespace PrograVisual.Vistas.Ventanas
{
    partial class FNumeroPerfecto
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
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Consola = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.Location = new System.Drawing.Point(410, 101);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(145, 45);
            this.BotonCalcular.TabIndex = 0;
            this.BotonCalcular.Text = "Calcular";
            this.BotonCalcular.UseVisualStyleBackColor = true;
            this.BotonCalcular.Click += new System.EventHandler(this.BotonCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa un Numero";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.Numero);
            this.panel1.Controls.Add(this.Consola);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BotonCalcular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 494);
            this.panel1.TabIndex = 3;
            // 
            // Numero
            // 
            this.Numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Numero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Numero.ForeColor = System.Drawing.SystemColors.Window;
            this.Numero.Location = new System.Drawing.Point(30, 66);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(525, 29);
            this.Numero.TabIndex = 4;
            this.Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Consola
            // 
            this.Consola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Consola.ForeColor = System.Drawing.SystemColors.Window;
            this.Consola.Location = new System.Drawing.Point(30, 101);
            this.Consola.Name = "Consola";
            this.Consola.ReadOnly = true;
            this.Consola.Size = new System.Drawing.Size(374, 372);
            this.Consola.TabIndex = 3;
            this.Consola.Text = "";
            // 
            // FNumeroPerfecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 494);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FNumeroPerfecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encontrar un número perfecto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox Consola;
        private System.Windows.Forms.TextBox Numero;
    }
}