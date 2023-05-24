using BML;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PVL.Tools
{
    public partial class frmNewProducer : DevExpress.XtraEditors.XtraForm
    {
        private int id = 0;
        private bool editMode = false;
        private bool editSave = false;
        public frmNewProducer()
        {
            InitializeComponent();
        }
        public frmNewProducer(int id)
        {
            InitializeComponent();
            this.id = id;
            Producer prod = new Producer() { idProducer = this.id }.GetByID();//producerBLL.GetByID(new BOL.Producer() { idProducer = this.id});
            txtName.Text = prod.name;
            editMode = true;
        }

        private void Message(int code)
        {
            switch (code)
            {
                case 1:
                    XtraMessageBox.Show("Campo vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtName.ErrorText = "Introduza un valor";
                    this.txtName.Focus();
                    break;
                case 2:
                    XtraMessageBox.Show("Elemento almacenado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    XtraMessageBox.Show("Elemento actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    XtraMessageBox.Show("Operación cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    XtraMessageBox.Show("Mensaje por default", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                if (!txtName.Text.Trim().Equals(""))
                {
                    if (new Producer() {name = txtName.Text.Trim() }.Add() > 0)
                    {
                        Message(2);
                    }
                }
                else
                {
                    Message(1);
                }
            }
            else
            {
                if (XtraMessageBox.Show("¿Desea guardar el cambio?", "Pregunta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    if (new Producer() { idProducer = this.id, name = txtName.Text.Trim() }.Update() > 0)
                    {
                        Message(3);
                        editSave = true;
                        this.Close();
                    }
                }
            }

        }

        private void frmNewProducer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!editMode)
            {
                if (XtraMessageBox.Show("¿Desea cerrar el formulario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    Message(4);
                    e.Cancel = true;
                }
            }
            else
            {
                if (!editSave)
                {
                    if (XtraMessageBox.Show("Se han realizado cambios al registro \n ¿Desea guardar los cambios?", "Advertencia"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        if (new Producer() { idProducer = this.id, name = txtName.Text.Trim() }.Update() > 0)
                        {
                            Message(3);
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}