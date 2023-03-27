
namespace PVL
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
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.writerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rlupWriter = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rlupDirector = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rlupProducer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gvMovies = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidMovie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidWriter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidDirector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProducer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colavailable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMovies = new DevExpress.XtraGrid.GridControl();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDrop = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupWriter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProducer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Herramientas";
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataSource = typeof(BOL.Movies);
            // 
            // writerBindingSource
            // 
            this.writerBindingSource.DataSource = typeof(BOL.Writer);
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataSource = typeof(BOL.Director);
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataSource = typeof(BOL.Producer);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(BOL.Movie);
            // 
            // rlupWriter
            // 
            this.rlupWriter.AutoHeight = false;
            this.rlupWriter.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupWriter.DataSource = this.writerBindingSource;
            this.rlupWriter.DisplayMember = "name";
            this.rlupWriter.Name = "rlupWriter";
            this.rlupWriter.ValueMember = "idWriter";
            // 
            // rlupDirector
            // 
            this.rlupDirector.AutoHeight = false;
            this.rlupDirector.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupDirector.DataSource = this.directorBindingSource;
            this.rlupDirector.DisplayMember = "name";
            this.rlupDirector.Name = "rlupDirector";
            this.rlupDirector.ValueMember = "idDirector";
            // 
            // rlupProducer
            // 
            this.rlupProducer.AutoHeight = false;
            this.rlupProducer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupProducer.DataSource = this.producerBindingSource;
            this.rlupProducer.DisplayMember = "name";
            this.rlupProducer.Name = "rlupProducer";
            this.rlupProducer.ValueMember = "idProducer";
            // 
            // gvMovies
            // 
            this.gvMovies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidMovie,
            this.coltitle,
            this.colidWriter,
            this.colidDirector,
            this.colidProducer,
            this.colavailable});
            this.gvMovies.DetailHeight = 465;
            this.gvMovies.GridControl = this.gcMovies;
            this.gvMovies.Name = "gvMovies";
            this.gvMovies.OptionsBehavior.Editable = false;
            this.gvMovies.OptionsView.ShowAutoFilterRow = true;
            this.gvMovies.OptionsView.ShowGroupPanel = false;
            // 
            // colidMovie
            // 
            this.colidMovie.FieldName = "idMovie";
            this.colidMovie.MinWidth = 31;
            this.colidMovie.Name = "colidMovie";
            this.colidMovie.Width = 117;
            // 
            // coltitle
            // 
            this.coltitle.FieldName = "title";
            this.coltitle.MinWidth = 31;
            this.coltitle.Name = "coltitle";
            this.coltitle.Visible = true;
            this.coltitle.VisibleIndex = 0;
            this.coltitle.Width = 117;
            // 
            // colidWriter
            // 
            this.colidWriter.Caption = "Escritor";
            this.colidWriter.ColumnEdit = this.rlupWriter;
            this.colidWriter.FieldName = "idWriter";
            this.colidWriter.MinWidth = 31;
            this.colidWriter.Name = "colidWriter";
            this.colidWriter.Visible = true;
            this.colidWriter.VisibleIndex = 1;
            this.colidWriter.Width = 117;
            // 
            // colidDirector
            // 
            this.colidDirector.Caption = "Director";
            this.colidDirector.ColumnEdit = this.rlupDirector;
            this.colidDirector.FieldName = "idDirector";
            this.colidDirector.MinWidth = 31;
            this.colidDirector.Name = "colidDirector";
            this.colidDirector.Visible = true;
            this.colidDirector.VisibleIndex = 2;
            this.colidDirector.Width = 117;
            // 
            // colidProducer
            // 
            this.colidProducer.Caption = "Productor";
            this.colidProducer.ColumnEdit = this.rlupProducer;
            this.colidProducer.FieldName = "idProducer";
            this.colidProducer.MinWidth = 31;
            this.colidProducer.Name = "colidProducer";
            this.colidProducer.Visible = true;
            this.colidProducer.VisibleIndex = 3;
            this.colidProducer.Width = 117;
            // 
            // colavailable
            // 
            this.colavailable.FieldName = "available";
            this.colavailable.MinWidth = 31;
            this.colavailable.Name = "colavailable";
            this.colavailable.Width = 117;
            // 
            // gcMovies
            // 
            this.gcMovies.DataSource = this.moviesBindingSource;
            this.gcMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMovies.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcMovies.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcMovies.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcMovies.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcMovies.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcMovies.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcMovies.Location = new System.Drawing.Point(0, 33);
            this.gcMovies.MainView = this.gvMovies;
            this.gcMovies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcMovies.Name = "gcMovies";
            this.gcMovies.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlupWriter,
            this.rlupDirector,
            this.rlupProducer});
            this.gcMovies.Size = new System.Drawing.Size(728, 458);
            this.gcMovies.TabIndex = 4;
            this.gcMovies.UseEmbeddedNavigator = true;
            this.gcMovies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMovies});
            // 
            // bar4
            // 
            this.bar4.BarName = "Barra de estado";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Barra de estado";
            this.bar4.Visible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLoad,
            this.btnAdd,
            this.btnEdit,
            this.btnDrop});
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Herramientas";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLoad, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDrop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.Text = "Herramientas";
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Load";
            this.btnLoad.Id = 0;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.LargeImage")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Add";
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDrop
            // 
            this.btnDrop.Caption = "Drop Down";
            this.btnDrop.Id = 3;
            this.btnDrop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDrop.ImageOptions.Image")));
            this.btnDrop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDrop.ImageOptions.LargeImage")));
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDrop_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(728, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 491);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(728, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(728, 33);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // frmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 491);
            this.Controls.Add(this.gcMovies);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMovies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de peliculas";
            this.Load += new System.EventHandler(this.frmMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupWriter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProducer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.BindingSource writerBindingSource;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private DevExpress.XtraGrid.GridControl gcMovies;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMovies;
        private DevExpress.XtraGrid.Columns.GridColumn colidMovie;
        private DevExpress.XtraGrid.Columns.GridColumn coltitle;
        private DevExpress.XtraGrid.Columns.GridColumn colidWriter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupWriter;
        private DevExpress.XtraGrid.Columns.GridColumn colidDirector;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupDirector;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducer;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlupProducer;
        private DevExpress.XtraGrid.Columns.GridColumn colavailable;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDrop;
    }
}