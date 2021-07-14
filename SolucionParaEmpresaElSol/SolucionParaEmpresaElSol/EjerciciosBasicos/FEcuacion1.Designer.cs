
namespace SolucionParaEmpresaElSol.EjerciciosBasicos
{
    partial class FEcuacion1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCoefA = new System.Windows.Forms.TextBox();
            this.textBoxCoefB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coeficiente a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coeficiente b";
            // 
            // textBoxCoefA
            // 
            this.textBoxCoefA.Location = new System.Drawing.Point(166, 27);
            this.textBoxCoefA.Name = "textBoxCoefA";
            this.textBoxCoefA.Size = new System.Drawing.Size(100, 23);
            this.textBoxCoefA.TabIndex = 2;
            // 
            // textBoxCoefB
            // 
            this.textBoxCoefB.Location = new System.Drawing.Point(166, 85);
            this.textBoxCoefB.Name = "textBoxCoefB";
            this.textBoxCoefB.Size = new System.Drawing.Size(100, 23);
            this.textBoxCoefB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LabelResultado
            // 
            this.LabelResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResultado.Location = new System.Drawing.Point(74, 190);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.Size = new System.Drawing.Size(154, 28);
            this.LabelResultado.TabIndex = 6;
            this.LabelResultado.Text = "Ingrese Datos";
            this.LabelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FEcuacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 237);
            this.Controls.Add(this.LabelResultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCoefB);
            this.Controls.Add(this.textBoxCoefA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FEcuacion1";
            this.Text = "Solucion para una Ecuación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCoefA;
        private System.Windows.Forms.TextBox textBoxCoefB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelResultado;
    }
}