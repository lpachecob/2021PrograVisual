
namespace SolucionParaEmpresaElSol.EjerciciosBasicos
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
            this.Consola.FormattingEnabled = true;
            this.Consola.ItemHeight = 15;
            this.Consola.Location = new System.Drawing.Point(17, 23);
            this.Consola.Name = "Consola";
            this.Consola.Size = new System.Drawing.Size(142, 424);
            this.Consola.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número Mayor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Menor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor Promedio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.texbox_Promedio);
            this.panel1.Controls.Add(this.texbox_NumeroMenor);
            this.panel1.Controls.Add(this.texbox_NumeroMayor);
            this.panel1.Controls.Add(this.Consola);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-5, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 460);
            this.panel1.TabIndex = 4;
            // 
            // texbox_Promedio
            // 
            this.texbox_Promedio.Location = new System.Drawing.Point(219, 245);
            this.texbox_Promedio.Name = "texbox_Promedio";
            this.texbox_Promedio.Size = new System.Drawing.Size(187, 23);
            this.texbox_Promedio.TabIndex = 6;
            // 
            // texbox_NumeroMenor
            // 
            this.texbox_NumeroMenor.Location = new System.Drawing.Point(220, 176);
            this.texbox_NumeroMenor.Name = "texbox_NumeroMenor";
            this.texbox_NumeroMenor.Size = new System.Drawing.Size(187, 23);
            this.texbox_NumeroMenor.TabIndex = 5;
            // 
            // texbox_NumeroMayor
            // 
            this.texbox_NumeroMayor.Location = new System.Drawing.Point(220, 108);
            this.texbox_NumeroMayor.Name = "texbox_NumeroMayor";
            this.texbox_NumeroMayor.Size = new System.Drawing.Size(186, 23);
            this.texbox_NumeroMayor.TabIndex = 4;
            // 
            // FControlListbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.panel1);
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