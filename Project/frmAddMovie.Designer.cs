namespace Project
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cbW = new System.Windows.Forms.ComboBox();
            this.writerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbD = new System.Windows.Forms.ComboBox();
            this.directorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.writerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(101, 41);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(265, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // cbW
            // 
            this.cbW.DataSource = this.writerBindingSource;
            this.cbW.DisplayMember = "name";
            this.cbW.FormattingEnabled = true;
            this.cbW.Location = new System.Drawing.Point(101, 97);
            this.cbW.Name = "cbW";
            this.cbW.Size = new System.Drawing.Size(265, 24);
            this.cbW.TabIndex = 4;
            this.cbW.ValueMember = "idWriter";
            // 
            // writerBindingSource
            // 
            this.writerBindingSource.DataSource = typeof(BOL.Writer);
            // 
            // cbD
            // 
            this.cbD.DataSource = this.directorBindingSource;
            this.cbD.DisplayMember = "name";
            this.cbD.FormattingEnabled = true;
            this.cbD.Location = new System.Drawing.Point(101, 156);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(265, 24);
            this.cbD.TabIndex = 5;
            this.cbD.ValueMember = "idDirector";
            // 
            // directorBindingSource
            // 
            this.directorBindingSource.DataSource = typeof(BOL.Director);
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataSource = typeof(BOL.Producer);
            // 
            // cbP
            // 
            this.cbP.DataSource = this.producerBindingSource;
            this.cbP.DisplayMember = "name";
            this.cbP.FormattingEnabled = true;
            this.cbP.Location = new System.Drawing.Point(101, 223);
            this.cbP.Name = "cbP";
            this.cbP.Size = new System.Drawing.Size(265, 24);
            this.cbP.TabIndex = 6;
            this.cbP.ValueMember = "idProducer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Escritor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Productora";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(294, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbP);
            this.Controls.Add(this.cbD);
            this.Controls.Add(this.cbW);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmAddMovie";
            this.Text = "-- Nueva Pelicula --";
            this.Load += new System.EventHandler(this.frmAddMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.writerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cbW;
        private System.Windows.Forms.ComboBox cbD;
        private System.Windows.Forms.ComboBox cbP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource writerBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private System.Windows.Forms.BindingSource directorBindingSource;
    }
}