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
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMovies = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWriter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDirectors = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProducers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.btnMovies,
            this.btnWriter,
            this.btnDirectors,
            this.btnProducers});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnMain.Size = new System.Drawing.Size(1067, 28);
            this.mnMain.TabIndex = 0;
            this.mnMain.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout});
            this.archivoToolStripMenuItem.Image = global::Project.Properties.Resources.File;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::Project.Properties.Resources.LogOut;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(179, 26);
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Image = global::Project.Properties.Resources.Movie;
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(99, 26);
            this.btnMovies.Text = "Peliculas";
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnWriter
            // 
            this.btnWriter.Image = global::Project.Properties.Resources.Writer;
            this.btnWriter.Name = "btnWriter";
            this.btnWriter.Size = new System.Drawing.Size(106, 26);
            this.btnWriter.Text = "Escritores";
            this.btnWriter.Click += new System.EventHandler(this.btnWriter_Click);
            // 
            // btnDirectors
            // 
            this.btnDirectors.Image = global::Project.Properties.Resources.Producer;
            this.btnDirectors.Name = "btnDirectors";
            this.btnDirectors.Size = new System.Drawing.Size(111, 26);
            this.btnDirectors.Text = "Directores";
            this.btnDirectors.Click += new System.EventHandler(this.btnDirectors_Click);
            // 
            // btnProducers
            // 
            this.btnProducers.Name = "btnProducers";
            this.btnProducers.Size = new System.Drawing.Size(102, 26);
            this.btnProducers.Text = "Productores";
            this.btnProducers.Click += new System.EventHandler(this.btnProducers_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mnMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-- Menu --";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem btnMovies;
        private System.Windows.Forms.ToolStripMenuItem btnWriter;
        private System.Windows.Forms.ToolStripMenuItem btnDirectors;
        private System.Windows.Forms.ToolStripMenuItem btnProducers;
    }
}