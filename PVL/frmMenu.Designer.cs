
namespace PVL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.mdiMain = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.mnMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnMenu = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewPassword = new DevExpress.XtraBars.BarSubItem();
            this.btnNewUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewPass = new DevExpress.XtraBars.BarButtonItem();
            this.skbCustom = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnFile = new DevExpress.XtraBars.BarSubItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::PVL.WaitForm1), true, true);
            this.panelMenu = new DevExpress.XtraEditors.SidePanel();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnProducers = new DevExpress.XtraEditors.SimpleButton();
            this.btnDirectors = new DevExpress.XtraEditors.SimpleButton();
            this.btnWriters = new DevExpress.XtraEditors.SimpleButton();
            this.btnMovies = new DevExpress.XtraEditors.SimpleButton();
            this.btnShoppingCart = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.mdiMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdiMain
            // 
            this.mdiMain.MdiParent = this;
            // 
            // mnMain
            // 
            this.mnMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.mnMain.DockControls.Add(this.barDockControlTop);
            this.mnMain.DockControls.Add(this.barDockControlBottom);
            this.mnMain.DockControls.Add(this.barDockControlLeft);
            this.mnMain.DockControls.Add(this.barDockControlRight);
            this.mnMain.Form = this;
            this.mnMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnFile,
            this.btnLogout,
            this.barSubItem1,
            this.btnNewPassword,
            this.btnNewUser,
            this.btnNewPass,
            this.skbCustom,
            this.btnMenu});
            this.mnMain.MaxItemId = 12;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewPassword),
            new DevExpress.XtraBars.LinkPersistInfo(this.skbCustom)});
            this.bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.All;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnMenu
            // 
            this.btnMenu.Caption = "Menu";
            this.btnMenu.Id = 11;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenu_ItemClick);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.Caption = "Herramientas";
            this.btnNewPassword.Id = 6;
            this.btnNewPassword.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewUser),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewPass)});
            this.btnNewPassword.Name = "btnNewPassword";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Caption = "Nuevo Usuario";
            this.btnNewUser.Id = 7;
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewUser_ItemClick);
            // 
            // btnNewPass
            // 
            this.btnNewPass.Caption = "Cambiar contraseña";
            this.btnNewPass.Id = 8;
            this.btnNewPass.Name = "btnNewPass";
            this.btnNewPass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewPass_ItemClick);
            // 
            // skbCustom
            // 
            this.skbCustom.Caption = "Personalización";
            this.skbCustom.Id = 10;
            this.skbCustom.Name = "skbCustom";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.mnMain;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(769, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 444);
            this.barDockControlBottom.Manager = this.mnMain;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(769, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlLeft.Appearance.Options.UseFont = true;
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.mnMain;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(769, 24);
            this.barDockControlRight.Manager = this.mnMain;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
            // 
            // btnFile
            // 
            this.btnFile.Caption = "Archivo";
            this.btnFile.Id = 0;
            this.btnFile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFile.ImageOptions.SvgImage")));
            this.btnFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLogout, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.btnFile.Name = "btnFile";
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Cerrar sesión";
            this.btnLogout.Id = 1;
            this.btnLogout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogout.ImageOptions.SvgImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Catalogos";
            this.barSubItem1.Id = 2;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 24);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(769, 0);
            this.fluentDesignFormControl1.TabIndex = 9;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnShoppingCart);
            this.panelMenu.Controls.Add(this.btnClose);
            this.panelMenu.Controls.Add(this.btnProducers);
            this.panelMenu.Controls.Add(this.btnDirectors);
            this.panelMenu.Controls.Add(this.btnWriters);
            this.panelMenu.Controls.Add(this.btnMovies);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(152, 420);
            this.panelMenu.TabIndex = 14;
            this.panelMenu.Text = "sidePanel1";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.ImageOptions.Image = global::PVL.Properties.Resources.logoutIcon;
            this.btnClose.Location = new System.Drawing.Point(0, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 64);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cerrar Sesión";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnProducers
            // 
            this.btnProducers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProducers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducers.ImageOptions.Image = global::PVL.Properties.Resources.producerIcon;
            this.btnProducers.Location = new System.Drawing.Point(0, 192);
            this.btnProducers.Name = "btnProducers";
            this.btnProducers.Size = new System.Drawing.Size(151, 64);
            this.btnProducers.TabIndex = 3;
            this.btnProducers.Text = "Productores";
            this.btnProducers.Click += new System.EventHandler(this.btnProducers_Click);
            // 
            // btnDirectors
            // 
            this.btnDirectors.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDirectors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDirectors.ImageOptions.Image = global::PVL.Properties.Resources.directorIcon;
            this.btnDirectors.Location = new System.Drawing.Point(0, 128);
            this.btnDirectors.Name = "btnDirectors";
            this.btnDirectors.Size = new System.Drawing.Size(151, 64);
            this.btnDirectors.TabIndex = 2;
            this.btnDirectors.Text = "Directores";
            this.btnDirectors.Click += new System.EventHandler(this.btnDirectors_Click);
            // 
            // btnWriters
            // 
            this.btnWriters.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWriters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWriters.ImageOptions.Image = global::PVL.Properties.Resources.writerIcon;
            this.btnWriters.Location = new System.Drawing.Point(0, 64);
            this.btnWriters.Name = "btnWriters";
            this.btnWriters.Size = new System.Drawing.Size(151, 64);
            this.btnWriters.TabIndex = 1;
            this.btnWriters.Text = "Escritores";
            this.btnWriters.Click += new System.EventHandler(this.btnWriters_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovies.ImageOptions.Image = global::PVL.Properties.Resources.moviesIcon2;
            this.btnMovies.Location = new System.Drawing.Point(0, 0);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(151, 64);
            this.btnMovies.TabIndex = 0;
            this.btnMovies.Text = "Películas";
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShoppingCart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnShoppingCart.Location = new System.Drawing.Point(0, 256);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(151, 64);
            this.btnShoppingCart.TabIndex = 5;
            this.btnShoppingCart.Text = "Ver carrito";
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(769, 444);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmMenu.IconOptions.SvgImage")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu PeliSoft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdiMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiMain;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager mnMain;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem btnFile;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem btnNewPassword;
        private DevExpress.XtraBars.BarButtonItem btnNewUser;
        private DevExpress.XtraBars.BarButtonItem btnNewPass;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.SkinBarSubItem skbCustom;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SidePanel panelMenu;
        private DevExpress.XtraEditors.SimpleButton btnMovies;
        private DevExpress.XtraEditors.SimpleButton btnProducers;
        private DevExpress.XtraEditors.SimpleButton btnDirectors;
        private DevExpress.XtraEditors.SimpleButton btnWriters;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraBars.BarButtonItem btnMenu;
        private DevExpress.XtraEditors.SimpleButton btnShoppingCart;
    }
}