
namespace PVL
{
    partial class frmDirector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirector));
            this.mnDirector = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDrop = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.gcDirector = new DevExpress.XtraGrid.GridControl();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDirector = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidDirector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mnDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDirector)).BeginInit();
            this.SuspendLayout();
            // 
            // mnDirector
            // 
            this.mnDirector.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.mnDirector.DockControls.Add(this.barDockControlTop);
            this.mnDirector.DockControls.Add(this.barDockControlBottom);
            this.mnDirector.DockControls.Add(this.barDockControlLeft);
            this.mnDirector.DockControls.Add(this.barDockControlRight);
            this.mnDirector.Form = this;
            this.mnDirector.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnLoad,
            this.btnAdd,
            this.btnEdit,
            this.btnDrop});
            this.mnDirector.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLoad, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDrop, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
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
            this.btnDrop.Caption = "Drop";
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
            this.barDockControlTop.Manager = this.mnDirector;
            this.barDockControlTop.Size = new System.Drawing.Size(799, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 570);
            this.barDockControlBottom.Manager = this.mnDirector;
            this.barDockControlBottom.Size = new System.Drawing.Size(799, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.mnDirector;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 537);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(799, 33);
            this.barDockControlRight.Manager = this.mnDirector;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 537);
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // gcDirector
            // 
            this.gcDirector.DataSource = this.directorBindingSource;
            this.gcDirector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDirector.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.gcDirector.Location = new System.Drawing.Point(0, 33);
            this.gcDirector.MainView = this.gvDirector;
            this.gcDirector.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.gcDirector.MenuManager = this.mnDirector;
            this.gcDirector.Name = "gcDirector";
            this.gcDirector.Size = new System.Drawing.Size(799, 537);
            this.gcDirector.TabIndex = 4;
            this.gcDirector.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDirector});
            this.gcDirector.Click += new System.EventHandler(this.gcDirector_Click);
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataSource = typeof(BOL.Director);
            // 
            // gvDirector
            // 
            this.gvDirector.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidDirector,
            this.colname,
            this.colactivo});
            this.gvDirector.DetailHeight = 852;
            this.gvDirector.GridControl = this.gcDirector;
            this.gvDirector.Name = "gvDirector";
            this.gvDirector.OptionsBehavior.Editable = false;
            // 
            // colidDirector
            // 
            this.colidDirector.FieldName = "idDirector";
            this.colidDirector.MinWidth = 61;
            this.colidDirector.Name = "colidDirector";
            this.colidDirector.Width = 227;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.MinWidth = 61;
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 227;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 61;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 227;
            // 
            // frmDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 570);
            this.Controls.Add(this.gcDirector);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDirector";
            this.Text = "Directores de cine";
            this.Load += new System.EventHandler(this.frmDirector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mnDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDirector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager mnDirector;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDrop;
        private DevExpress.XtraGrid.GridControl gcDirector;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDirector;
        private DevExpress.XtraGrid.Columns.GridColumn colidDirector;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}