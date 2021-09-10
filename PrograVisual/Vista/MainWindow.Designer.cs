
namespace PrograVisual.Vista
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.PictureBox();
            this.ListaApp = new System.Windows.Forms.ListBox();
            this.WindowApp = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 371);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.ListaApp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 268);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Start);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 103);
            this.panel2.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.Location = new System.Drawing.Point(0, 0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(182, 103);
            this.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Start.TabIndex = 0;
            this.Start.TabStop = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ListaApp
            // 
            this.ListaApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ListaApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListaApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaApp.ForeColor = System.Drawing.SystemColors.Info;
            this.ListaApp.FormattingEnabled = true;
            this.ListaApp.Location = new System.Drawing.Point(0, 0);
            this.ListaApp.Name = "ListaApp";
            this.ListaApp.Size = new System.Drawing.Size(182, 268);
            this.ListaApp.TabIndex = 0;
            this.ListaApp.SelectedIndexChanged += new System.EventHandler(this.ListaApp_SelectedIndexChanged);
            // 
            // WindowApp
            // 
            this.WindowApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WindowApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowApp.Location = new System.Drawing.Point(182, 0);
            this.WindowApp.Name = "WindowApp";
            this.WindowApp.Size = new System.Drawing.Size(621, 371);
            this.WindowApp.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 371);
            this.Controls.Add(this.WindowApp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Start;
        private System.Windows.Forms.Panel WindowApp;
        private System.Windows.Forms.ListBox ListaApp;
    }
}