
namespace SolucionParaEmpresaElSol.EjerciciosBasicos
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
            this.Consola = new System.Windows.Forms.RichTextBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.Location = new System.Drawing.Point(283, 78);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(75, 23);
            this.BotonCalcular.TabIndex = 0;
            this.BotonCalcular.Text = "Calcular";
            this.BotonCalcular.UseVisualStyleBackColor = true;
            this.BotonCalcular.Click += new System.EventHandler(this.BotonCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa un Numero";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.Numero);
            this.panel1.Controls.Add(this.Consola);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BotonCalcular);
            this.panel1.Location = new System.Drawing.Point(-10, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 461);
            this.panel1.TabIndex = 3;
            // 
            // Consola
            // 
            this.Consola.Location = new System.Drawing.Point(31, 78);
            this.Consola.Name = "Consola";
            this.Consola.ReadOnly = true;
            this.Consola.Size = new System.Drawing.Size(246, 372);
            this.Consola.TabIndex = 3;
            this.Consola.Text = "";
            // 
            // Numero
            // 
            this.Numero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Numero.Location = new System.Drawing.Point(146, 36);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(212, 29);
            this.Numero.TabIndex = 4;
            this.Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FNumeroPerfecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.panel1);
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