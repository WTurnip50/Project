
namespace PVL
{
    partial class frmAddMovie
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
            this.writerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rlupWriter = new DevExpress.XtraEditors.LookUpEdit();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rlupDirector = new DevExpress.XtraEditors.LookUpEdit();
            this.rlupProducer = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.writerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupWriter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupDirector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProducer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // writerBindingSource
            // 
            this.writerBindingSource.DataSource = typeof(BOL.Writer);
            // 
            // rlupWriter
            // 
            this.rlupWriter.Location = new System.Drawing.Point(128, 154);
            this.rlupWriter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rlupWriter.Name = "rlupWriter";
            this.rlupWriter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupWriter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idWriter", "id Writer", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Escritor", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 69, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupWriter.Properties.DataSource = this.writerBindingSource;
            this.rlupWriter.Properties.DisplayMember = "name";
            this.rlupWriter.Properties.NullText = "";
            this.rlupWriter.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.rlupWriter.Properties.PopupSizeable = false;
            this.rlupWriter.Properties.ValueMember = "idWriter";
            this.rlupWriter.Size = new System.Drawing.Size(195, 34);
            this.rlupWriter.TabIndex = 0;
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataSource = typeof(BOL.Director);
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataSource = typeof(BOL.Producer);
            // 
            // rlupDirector
            // 
            this.rlupDirector.EditValue = "";
            this.rlupDirector.Location = new System.Drawing.Point(128, 236);
            this.rlupDirector.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rlupDirector.Name = "rlupDirector";
            this.rlupDirector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupDirector.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idDirector", "id Director", 109, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Director", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 69, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupDirector.Properties.DataSource = this.directorBindingSource;
            this.rlupDirector.Properties.DisplayMember = "name";
            this.rlupDirector.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.rlupDirector.Properties.SuppressMouseEventOnOuterMouseClick = true;
            this.rlupDirector.Properties.ValueMember = "idDirector";
            this.rlupDirector.Size = new System.Drawing.Size(195, 34);
            this.rlupDirector.TabIndex = 1;
            // 
            // rlupProducer
            // 
            this.rlupProducer.EditValue = "";
            this.rlupProducer.Location = new System.Drawing.Point(128, 323);
            this.rlupProducer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rlupProducer.Name = "rlupProducer";
            this.rlupProducer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlupProducer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("idProducer", "id Producer", 119, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Productor", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("activo", "activo", 69, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.rlupProducer.Properties.DataSource = this.producerBindingSource;
            this.rlupProducer.Properties.DisplayMember = "name";
            this.rlupProducer.Properties.Padding = new System.Windows.Forms.Padding(5);
            this.rlupProducer.Properties.ValueMember = "idProducer";
            this.rlupProducer.Size = new System.Drawing.Size(195, 34);
            this.rlupProducer.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 162);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Escritor";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 244);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Director";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(35, 331);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 17);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Productor";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(35, 56);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 17);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Titulo";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(128, 53);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Properties.Appearance.Options.UseFont = true;
            this.txtTitle.Size = new System.Drawing.Size(195, 34);
            this.txtTitle.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(229, 396);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(35, 396);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(91, 46);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmAddMovie
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(337, 468);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.rlupWriter);
            this.Controls.Add(this.rlupDirector);
            this.Controls.Add(this.rlupProducer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Pélicula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddMovie_FormClosing);
            this.Load += new System.EventHandler(this.frmAddMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.writerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupWriter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupDirector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlupProducer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource writerBindingSource;
        private DevExpress.XtraEditors.LookUpEdit rlupWriter;
        private System.Windows.Forms.BindingSource directorBindingSource;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private DevExpress.XtraEditors.LookUpEdit rlupDirector;
        private DevExpress.XtraEditors.LookUpEdit rlupProducer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
    }
}