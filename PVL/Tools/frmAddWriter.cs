using BLL;
using BOL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVL
{
    public partial class frmAddWriter : DevExpress.XtraEditors.XtraForm
    {
        private WriterBLL writerBll = WriterBLL.Instance();
        private bool editMode = false;
        private string name = "";
        private bool editSave = false;
        private int id = 0;
        public frmAddWriter()
        {
            InitializeComponent();
        }
        public frmAddWriter(int id)
        {
            InitializeComponent();
            this.id = id;
            Writer writer = writerBll.GetByID(new BOL.Writer() { idWriter = this.id});
            MessageBox.Show(writer.name);
            this.name = writer.name.Trim();
            txtWriter.Text = name; 
            this.editMode = true;
        }

        private bool isEdit()
        {
            return editMode;
        }

        private bool isDifferent()
        {
            if (!this.name.Equals(txtWriter.Text.Trim()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void clean()
        {
            this.txtWriter.Text = "";
            this.txtWriter.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isEdit())
            {
                if (!txtWriter.Text.Equals(""))
                {
                    if (writerBll.Add(new BOL.Writer() { name = txtWriter.Text.Trim() }))
                    {
                        XtraMessageBox.Show("Elemento almacenado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clean();
                    }
                }

            }
            else
            {
                if (!txtWriter.Text.Equals(""))
                {
                    if (writerBll.Edit(new BOL.Writer() { idWriter = this.id, name = txtWriter.Text.Trim() }))
                    {
                        XtraMessageBox.Show("Elemento actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        editSave = true;
                    }
                }
            }
        }

        private void frmAddWriter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!editSave)
            {
                if (isDifferent())
                {
                    if (XtraMessageBox.Show("Se han realizado cambios a la información" + "\n Desea Almacenarlos", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        if (isEdit())
                        {
                            if (writerBll.Edit(new BOL.Writer() { idWriter = this.id, name = txtWriter.Text.Trim() }))
                            {
                                XtraMessageBox.Show("Se han guardado los cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            this.editMode = false;
                        }
                        else
                        {
                            if (writerBll.Add(new BOL.Writer() { name = this.txtWriter.Text.Trim() }))
                            {
                                XtraMessageBox.Show("Se han guardado los cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    if (XtraMessageBox.Show("Desea Cerrar el formulario", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void frmAddWriter_Load(object sender, EventArgs e)
        {

        }
    }
}