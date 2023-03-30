
namespace PVL
{
    partial class frmWriters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWriters));
            this.mnWriter = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDrop = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.gcWriter = new DevExpress.XtraGrid.GridControl();
            this.writerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvWriter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidWriter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mnWriter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcWriter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWriter)).BeginInit();
            this.SuspendLayout();
            // 
            // mnWriter
            // 
            this.mnWriter.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.mnWriter.DockControls.Add(this.barDockControlTop);
            this.mnWriter.DockControls.Add(this.barDockControlBottom);
            this.mnWriter.DockControls.Add(this.barDockControlLeft);
            this.mnWriter.DockControls.Add(this.barDockControlRight);
            this.mnWriter.Form = this;
            this.mnWriter.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barCheckItem1,
            this.btnLoad,
            this.btnAdd,
            this.btnEdit,
            this.btnDrop});
            this.mnWriter.MaxItemId = 5;
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
            this.btnLoad.Id = 1;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.LargeImage")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Add";
            this.btnAdd.Id = 2;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 3;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDrop
            // 
            this.btnDrop.Caption = "Drop";
            this.btnDrop.Id = 4;
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
            this.barDockControlTop.Manager = this.mnWriter;
            this.barDockControlTop.Size = new System.Drawing.Size(847, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 554);
            this.barDockControlBottom.Manager = this.mnWriter;
            this.barDockControlBottom.Size = new System.Drawing.Size(847, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.mnWriter;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 521);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(847, 33);
            this.barDockControlRight.Manager = this.mnWriter;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 521);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 0;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // gcWriter
            // 
            this.gcWriter.DataSource = this.writerBindingSource;
            this.gcWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcWriter.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcWriter.Location = new System.Drawing.Point(0, 33);
            this.gcWriter.MainView = this.gvWriter;
            this.gcWriter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcWriter.MenuManager = this.mnWriter;
            this.gcWriter.Name = "gcWriter";
            this.gcWriter.Size = new System.Drawing.Size(847, 521);
            this.gcWriter.TabIndex = 4;
            this.gcWriter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWriter});
            // 
            // writerBindingSource
            // 
            this.writerBindingSource.DataSource = typeof(BOL.Writer);
            // 
            // gvWriter
            // 
            this.gvWriter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidWriter,
            this.colname,
            this.colactivo});
            this.gvWriter.DetailHeight = 437;
            this.gvWriter.GridControl = this.gcWriter;
            this.gvWriter.Name = "gvWriter";
            // 
            // colidWriter
            // 
            this.colidWriter.FieldName = "idWriter";
            this.colidWriter.MinWidth = 31;
            this.colidWriter.Name = "colidWriter";
            this.colidWriter.Width = 117;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.MinWidth = 31;
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 117;
            // 
            // colactivo
            // 
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 31;
            this.colactivo.Name = "colactivo";
            this.colactivo.Width = 117;
            // 
            // frmWriters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 554);
            this.Controls.Add(this.gcWriter);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmWriters";
            this.Text = "Lista de Escritores";
            this.Load += new System.EventHandler(this.frmWriters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mnWriter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcWriter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWriter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager mnWriter;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDrop;
        private DevExpress.XtraGrid.GridControl gcWriter;
        private System.Windows.Forms.BindingSource writerBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWriter;
        private DevExpress.XtraGrid.Columns.GridColumn colidWriter;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
    }
}