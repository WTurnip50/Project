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
    public partial class frmAddDirector : DevExpress.XtraEditors.XtraForm
    {
        private DirectorBLL directorBLL = DirectorBLL.Instance();
        private bool editMode = false;
        private bool editSave = false;
        private int id = 0;
        private string name = "";

        public frmAddDirector()
        {
            InitializeComponent();
        }

        public frmAddDirector(int id)
        {
            InitializeComponent();
            this.id = id;
            Director director = directorBLL.getByID(new BOL.Director() { idDirector = this.id});
            txtDirector.Text = director.name.Trim();
            this.name = director.name.Trim();
            this.editMode = true;
        }

        private void clean()
        {
            this.txtDirector.ResetText();
        }

        private bool isEdit()
        {
            return editMode;
        }

        private bool isDifferent()
        {
            if (!this.name.Equals(txtDirector.Text.Trim()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isEdit())
            {
                if (!txtDirector.Text.Equals(""))
                {
                    if (directorBLL.Add(new BOL.Director() { name = txtDirector.Text.Trim() }))
                    {
                        XtraMessageBox.Show("Elemento almacenado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clean();
                    }
                }
                
            }
            else
            {
                if (!txtDirector.Text.Equals(""))
                {
                    if (directorBLL.Edit(new BOL.Director() { idDirector = this.id, name = txtDirector.Text.Trim()}))
                    {
                        XtraMessageBox.Show("Elemento actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        editSave = true;
                    }
                }
            }

            
        }



        private void frmAddDirector_Load(object sender, EventArgs e)
        {

        }

        private void frmAddDirector_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!editSave) {
                if (isDifferent())
                {
                    if (XtraMessageBox.Show("Se han realizado cambios a la información" + "\n Desea Almacenarlos", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        if (isEdit())
                        {
                            if (directorBLL.Edit(new BOL.Director() { idDirector = this.id, name = txtDirector.Text.Trim() }))
                            {
                                XtraMessageBox.Show("Se han guardado los cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            this.editMode = false;
                        }
                        else
                        {
                            if (directorBLL.Add(new BOL.Director() { name = this.txtDirector.Text.Trim() }))
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
    }
}