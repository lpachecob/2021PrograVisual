
namespace PrograVisual.Vistas
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenuBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListaDeProyectos = new System.Windows.Forms.ListBox();
            this.Container = new System.Windows.Forms.Panel();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuBar.Controls.Add(this.pictureBox1);
            this.MenuBar.Controls.Add(this.ListaDeProyectos);
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBar.ForeColor = System.Drawing.SystemColors.Window;
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(225, 514);
            this.MenuBar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListaDeProyectos
            // 
            this.ListaDeProyectos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListaDeProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ListaDeProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaDeProyectos.ForeColor = System.Drawing.SystemColors.Window;
            this.ListaDeProyectos.FormattingEnabled = true;
            this.ListaDeProyectos.ItemHeight = 15;
            this.ListaDeProyectos.Location = new System.Drawing.Point(12, 107);
            this.ListaDeProyectos.Name = "ListaDeProyectos";
            this.ListaDeProyectos.Size = new System.Drawing.Size(202, 375);
            this.ListaDeProyectos.TabIndex = 0;
            this.ListaDeProyectos.SelectedIndexChanged += new System.EventHandler(this.ListaDeProyectos_SelectedIndexChanged);
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(225, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(592, 514);
            this.Container.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 514);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.MenuBar);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.ListBox ListaDeProyectos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}