using BML;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PVL
{
    public partial class frmNUser : DevExpress.XtraEditors.XtraForm
    {
        
        private bool SU = false;
        public frmNUser()
        {
            InitializeComponent();
        }
        private void Save(bool SU)
        {
            if (new User() { username = txtName.Text.Trim(),password = txtPass.Text.Trim(), SU = this.SU}.newUser()>0)
            {
                Message(1);
            }
        }
        private void Message(int type)
        {
            switch (type)
            {
                case 1:
                    XtraMessageBox.Show("Usuario Añadido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    XtraMessageBox.Show("Acción cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 3:
                    XtraMessageBox.Show("Usuario no disponible \n Pruebe con otro nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 4:
                    XtraMessageBox.Show("Usuario Disponible.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    XtraMessageBox.Show("Mensaje por default", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private bool available()
        {
            if (new User() {username = txtName.Text.Trim() }.GetByUser() != null)
            {
                Message(3);
                return true;
            }
            else
            {
                this.txtName.Focus();
                Message(4);
                return false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SU = (bool) cbSU.EditValue;


            if (!available())
            {
                if (!this.SU)
                {
                    Save(this.SU);
                }
                else
                {
                    if (XtraMessageBox.Show("¿Desea otorgar permisos avanzados al usuario?",
                    "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        Save(this.SU);
                    }
                    else
                    {
                        Message(2);
                    }
                }
            }

        }

        private void frmNUser_Load(object sender, EventArgs e)
        {

        }
    }
}