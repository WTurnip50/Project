namespace Project
{
    partial class frmMovies
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
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idProducerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDirectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWriterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMovieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvMovies);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 422);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate,
            this.btnAdd,
            this.btnEdit,
            this.btnDisable});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 24);
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 24);
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 24);
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(101, 24);
            this.btnDisable.Text = "Dar de baja";
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(BOL.Movie);
            // 
            // available
            // 
            this.available.DataPropertyName = "available";
            this.available.HeaderText = "available";
            this.available.MinimumWidth = 6;
            this.available.Name = "available";
            this.available.ReadOnly = true;
            this.available.Visible = false;
            this.available.Width = 125;
            // 
            // idProducerDataGridViewTextBoxColumn
            // 
            this.idProducerDataGridViewTextBoxColumn.DataPropertyName = "idProducer";
            this.idProducerDataGridViewTextBoxColumn.HeaderText = "idProducer";
            this.idProducerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProducerDataGridViewTextBoxColumn.Name = "idProducerDataGridViewTextBoxColumn";
            this.idProducerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProducerDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDirectorDataGridViewTextBoxColumn
            // 
            this.idDirectorDataGridViewTextBoxColumn.DataPropertyName = "idDirector";
            this.idDirectorDataGridViewTextBoxColumn.HeaderText = "idDirector";
            this.idDirectorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDirectorDataGridViewTextBoxColumn.Name = "idDirectorDataGridViewTextBoxColumn";
            this.idDirectorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDirectorDataGridViewTextBoxColumn.Width = 125;
            // 
            // idWriterDataGridViewTextBoxColumn
            // 
            this.idWriterDataGridViewTextBoxColumn.DataPropertyName = "idWriter";
            this.idWriterDataGridViewTextBoxColumn.HeaderText = "idWriter";
            this.idWriterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idWriterDataGridViewTextBoxColumn.Name = "idWriterDataGridViewTextBoxColumn";
            this.idWriterDataGridViewTextBoxColumn.ReadOnly = true;
            this.idWriterDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // idMovieDataGridViewTextBoxColumn
            // 
            this.idMovieDataGridViewTextBoxColumn.DataPropertyName = "idMovie";
            this.idMovieDataGridViewTextBoxColumn.HeaderText = "idMovie";
            this.idMovieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMovieDataGridViewTextBoxColumn.Name = "idMovieDataGridViewTextBoxColumn";
            this.idMovieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMovieDataGridViewTextBoxColumn.Visible = false;
            this.idMovieDataGridViewTextBoxColumn.Width = 125;
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.AutoGenerateColumns = false;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMovieDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.idWriterDataGridViewTextBoxColumn,
            this.idDirectorDataGridViewTextBoxColumn,
            this.idProducerDataGridViewTextBoxColumn,
            this.available});
            this.dgvMovies.DataSource = this.movieBindingSource;
            this.dgvMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovies.Location = new System.Drawing.Point(0, 0);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.RowTemplate.Height = 24;
            this.dgvMovies.Size = new System.Drawing.Size(800, 422);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick);
            // 
            // frmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peliculas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMovies_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripMenuItem btnDisable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWriterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDirectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn available;
    }
}