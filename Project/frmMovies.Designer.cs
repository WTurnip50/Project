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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovies));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.idMovieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWriterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDirectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDisable = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvMovies);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 423);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
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
            this.avaliable});
            this.dgvMovies.DataSource = this.movieBindingSource;
            this.dgvMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovies.Location = new System.Drawing.Point(0, 0);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.RowTemplate.Height = 24;
            this.dgvMovies.Size = new System.Drawing.Size(800, 423);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick);
            // 
            // idMovieDataGridViewTextBoxColumn
            // 
            this.idMovieDataGridViewTextBoxColumn.DataPropertyName = "idMovie";
            this.idMovieDataGridViewTextBoxColumn.HeaderText = "idMovie";
            this.idMovieDataGridViewTextBoxColumn.Name = "idMovieDataGridViewTextBoxColumn";
            this.idMovieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMovieDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idWriterDataGridViewTextBoxColumn
            // 
            this.idWriterDataGridViewTextBoxColumn.DataPropertyName = "idWriter";
            this.idWriterDataGridViewTextBoxColumn.HeaderText = "idWriter";
            this.idWriterDataGridViewTextBoxColumn.Name = "idWriterDataGridViewTextBoxColumn";
            this.idWriterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDirectorDataGridViewTextBoxColumn
            // 
            this.idDirectorDataGridViewTextBoxColumn.DataPropertyName = "idDirector";
            this.idDirectorDataGridViewTextBoxColumn.HeaderText = "idDirector";
            this.idDirectorDataGridViewTextBoxColumn.Name = "idDirectorDataGridViewTextBoxColumn";
            this.idDirectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProducerDataGridViewTextBoxColumn
            // 
            this.idProducerDataGridViewTextBoxColumn.DataPropertyName = "idProducer";
            this.idProducerDataGridViewTextBoxColumn.HeaderText = "idProducer";
            this.idProducerDataGridViewTextBoxColumn.Name = "idProducerDataGridViewTextBoxColumn";
            this.idProducerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avaliable
            // 
            this.avaliable.DataPropertyName = "avaliable";
            this.avaliable.HeaderText = "avaliable";
            this.avaliable.Name = "avaliable";
            this.avaliable.ReadOnly = true;
            this.avaliable.Visible = false;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(BOL.Movie);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnAdd,
            this.btnEdit,
            this.btnDisable});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(372, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 24);
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 24);
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 24);
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Image = ((System.Drawing.Image)(resources.GetObject("btnDisable.Image")));
            this.btnDisable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(111, 24);
            this.btnDisable.Text = "Dar de Baja";
            // 
            // frmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmMovies";
            this.Text = "frmMovies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMovies_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDisable;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMovieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWriterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDirectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn avaliable;
    }
}