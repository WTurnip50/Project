namespace Project
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovies = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWriter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDirectors = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProducers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.btnMovies,
            this.btnWriter,
            this.btnDirectors,
            this.btnProducers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout});
            this.archivoToolStripMenuItem.Image = global::Project.Properties.Resources.File;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::Project.Properties.Resources.LogOut;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(224, 26);
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Image = global::Project.Properties.Resources.Movie;
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(99, 24);
            this.btnMovies.Text = "Peliculas";
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnWriter
            // 
            this.btnWriter.Image = global::Project.Properties.Resources.Writer;
            this.btnWriter.Name = "btnWriter";
            this.btnWriter.Size = new System.Drawing.Size(106, 24);
            this.btnWriter.Text = "Escritores";
            this.btnWriter.Click += new System.EventHandler(this.btnWriter_Click);
            // 
            // btnDirectors
            // 
            this.btnDirectors.Image = global::Project.Properties.Resources.Producer;
            this.btnDirectors.Name = "btnDirectors";
            this.btnDirectors.Size = new System.Drawing.Size(111, 24);
            this.btnDirectors.Text = "Directores";
            this.btnDirectors.Click += new System.EventHandler(this.btnDirectors_Click);
            // 
            // btnProducers
            // 
            this.btnProducers.Name = "btnProducers";
            this.btnProducers.Size = new System.Drawing.Size(102, 24);
            this.btnProducers.Text = "Productores";
            this.btnProducers.Click += new System.EventHandler(this.btnProducers_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-- Menu --";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem btnMovies;
        private System.Windows.Forms.ToolStripMenuItem btnWriter;
        private System.Windows.Forms.ToolStripMenuItem btnDirectors;
        private System.Windows.Forms.ToolStripMenuItem btnProducers;
    }
}