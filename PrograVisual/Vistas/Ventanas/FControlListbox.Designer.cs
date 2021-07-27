
namespace PrograVisual.Vistas.Ventanas
{
    partial class FControlListbox
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
            this.Consola = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.texbox_Promedio = new System.Windows.Forms.TextBox();
            this.texbox_NumeroMenor = new System.Windows.Forms.TextBox();
            this.texbox_NumeroMayor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Consola
            // 
            this.Consola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Consola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Consola.ForeColor = System.Drawing.SystemColors.Window;
            this.Consola.FormattingEnabled = true;
            this.Consola.ItemHeight = 15;
            this.Consola.Location = new System.Drawing.Point(30, 35);
            this.Consola.Name = "Consola";
            this.Consola.Size = new System.Drawing.Size(202, 420);
            this.Consola.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(299, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número Mayor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(298, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Menor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(299, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor Promedio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.texbox_Promedio);
            this.panel1.Controls.Add(this.texbox_NumeroMenor);
            this.panel1.Controls.Add(this.texbox_NumeroMayor);
            this.panel1.Controls.Add(this.Consola);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 494);
            this.panel1.TabIndex = 4;
            // 
            // texbox_Promedio
            // 
            this.texbox_Promedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.texbox_Promedio.ForeColor = System.Drawing.SystemColors.Window;
            this.texbox_Promedio.Location = new System.Drawing.Point(317, 250);
            this.texbox_Promedio.Name = "texbox_Promedio";
            this.texbox_Promedio.Size = new System.Drawing.Size(187, 23);
            this.texbox_Promedio.TabIndex = 6;
            // 
            // texbox_NumeroMenor
            // 
            this.texbox_NumeroMenor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.texbox_NumeroMenor.ForeColor = System.Drawing.SystemColors.Window;
            this.texbox_NumeroMenor.Location = new System.Drawing.Point(318, 181);
            this.texbox_NumeroMenor.Name = "texbox_NumeroMenor";
            this.texbox_NumeroMenor.Size = new System.Drawing.Size(187, 23);
            this.texbox_NumeroMenor.TabIndex = 5;
            // 
            // texbox_NumeroMayor
            // 
            this.texbox_NumeroMayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.texbox_NumeroMayor.ForeColor = System.Drawing.SystemColors.Window;
            this.texbox_NumeroMayor.Location = new System.Drawing.Point(318, 113);
            this.texbox_NumeroMayor.Name = "texbox_NumeroMayor";
            this.texbox_NumeroMayor.Size = new System.Drawing.Size(186, 23);
            this.texbox_NumeroMayor.TabIndex = 4;
            // 
            // FControlListbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(592, 494);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FControlListbox";
            this.Text = "Ejercicio con listbox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Consola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox texbox_Promedio;
        private System.Windows.Forms.TextBox texbox_NumeroMenor;
        private System.Windows.Forms.TextBox texbox_NumeroMayor;
    }
}