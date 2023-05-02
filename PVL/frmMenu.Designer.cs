
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
            this.btnFile = new DevExpress.XtraBars.BarSubItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnMovies = new DevExpress.XtraBars.BarButtonItem();
            this.btnWriters = new DevExpress.XtraBars.BarButtonItem();
            this.btnDirectors = new DevExpress.XtraBars.BarButtonItem();
            this.btnProducers = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewPassword = new DevExpress.XtraBars.BarSubItem();
            this.btnNewUser = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewPass = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.mdiMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
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
            this.btnMovies,
            this.btnDirectors,
            this.btnWriters,
            this.btnNewPassword,
            this.btnNewUser,
            this.btnNewPass,
            this.btnProducers});
            this.mnMain.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnFile, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewPassword)});
            this.bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.All;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
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
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMovies),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWriters),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDirectors),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProducers)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnMovies
            // 
            this.btnMovies.Caption = "Películas";
            this.btnMovies.Id = 3;
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMovies_ItemClick);
            // 
            // btnWriters
            // 
            this.btnWriters.Caption = "Escritores";
            this.btnWriters.Id = 5;
            this.btnWriters.Name = "btnWriters";
            this.btnWriters.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWriters_ItemClick);
            // 
            // btnDirectors
            // 
            this.btnDirectors.Caption = "Directores";
            this.btnDirectors.Id = 4;
            this.btnDirectors.Name = "btnDirectors";
            this.btnDirectors.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDirectors_ItemClick);
            // 
            // btnProducers
            // 
            this.btnProducers.Caption = "Productoras";
            this.btnProducers.Id = 9;
            this.btnProducers.Name = "btnProducers";
            this.btnProducers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProducers_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.mnMain;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(769, 28);
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
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.mnMain;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 416);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(769, 28);
            this.barDockControlRight.Manager = this.mnMain;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 416);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 28);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(769, 0);
            this.fluentDesignFormControl1.TabIndex = 9;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 444);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmMenu.IconOptions.SvgImage")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu PeliSoft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdiMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnMovies;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDirectors;
        private DevExpress.XtraBars.BarButtonItem btnWriters;
        private DevExpress.XtraBars.BarSubItem btnNewPassword;
        private DevExpress.XtraBars.BarButtonItem btnNewUser;
        private DevExpress.XtraBars.BarButtonItem btnNewPass;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.BarButtonItem btnProducers;
    }
}