
namespace PVL
{
    partial class ShoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCart));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.btnSale = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcCart = new DevExpress.XtraGrid.GridControl();
            this.gvCart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colidMovie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupMovie = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.btnSale);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel1.Location = new System.Drawing.Point(0, 331);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(468, 38);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "pnlButton";
            // 
            // btnSale
            // 
            this.btnSale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSale.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSale.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSale.ImageOptions.SvgImage")));
            this.btnSale.Location = new System.Drawing.Point(0, 0);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(468, 38);
            this.btnSale.TabIndex = 0;
            this.btnSale.Text = "Realizar compra";
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDelete});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Eliminar de carrito";
            this.btnDelete.Id = 0;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(468, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 369);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(468, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 345);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(468, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 345);
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataSource = typeof(BML.Cart);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BML.User);
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataSource = typeof(BML.Sales);
            // 
            // gcCart
            // 
            this.gcCart.DataSource = this.cartBindingSource;
            this.gcCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCart.Location = new System.Drawing.Point(0, 24);
            this.gcCart.MainView = this.gvCart;
            this.gcCart.MenuManager = this.barManager1;
            this.gcCart.Name = "gcCart";
            this.gcCart.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lupUser,
            this.lupMovie});
            this.gcCart.Size = new System.Drawing.Size(468, 307);
            this.gcCart.TabIndex = 10;
            this.gcCart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCart});
            // 
            // gvCart
            // 
            this.gvCart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCart,
            this.colidUser,
            this.colidMovie,
            this.colprecio});
            this.gvCart.GridControl = this.gcCart;
            this.gvCart.Name = "gvCart";
            this.gvCart.OptionsBehavior.Editable = false;
            this.gvCart.OptionsView.ShowGroupPanel = false;
            // 
            // colidCart
            // 
            this.colidCart.FieldName = "idCart";
            this.colidCart.Name = "colidCart";
            // 
            // colidUser
            // 
            this.colidUser.Caption = "Usuario";
            this.colidUser.ColumnEdit = this.lupUser;
            this.colidUser.FieldName = "idUser";
            this.colidUser.Name = "colidUser";
            this.colidUser.OptionsColumn.AllowEdit = false;
            this.colidUser.Visible = true;
            this.colidUser.VisibleIndex = 0;
            // 
            // lupUser
            // 
            this.lupUser.AutoHeight = false;
            this.lupUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupUser.DataSource = this.userBindingSource;
            this.lupUser.DisplayMember = "username";
            this.lupUser.Name = "lupUser";
            this.lupUser.ValueMember = "idUser";
            // 
            // colidMovie
            // 
            this.colidMovie.Caption = "Película";
            this.colidMovie.ColumnEdit = this.lupMovie;
            this.colidMovie.FieldName = "idMovie";
            this.colidMovie.Name = "colidMovie";
            this.colidMovie.OptionsColumn.AllowEdit = false;
            this.colidMovie.Visible = true;
            this.colidMovie.VisibleIndex = 1;
            // 
            // lupMovie
            // 
            this.lupMovie.AutoHeight = false;
            this.lupMovie.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupMovie.DataSource = this.peliculaBindingSource;
            this.lupMovie.DisplayMember = "title";
            this.lupMovie.Name = "lupMovie";
            this.lupMovie.ValueMember = "idMovie";
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataSource = typeof(BML.Pelicula);
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 2;
            // 
            // ShoppingCart
            // 
            this.AcceptButton = this.btnSale;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 369);
            this.Controls.Add(this.gcCart);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ShoppingCart.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SimpleButton btnSale;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private DevExpress.XtraGrid.GridControl gcCart;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCart;
        private DevExpress.XtraGrid.Columns.GridColumn colidCart;
        private DevExpress.XtraGrid.Columns.GridColumn colidUser;
        private DevExpress.XtraGrid.Columns.GridColumn colidMovie;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lupUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lupMovie;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
    }
}