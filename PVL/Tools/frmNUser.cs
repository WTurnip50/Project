using BLL;
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
    public partial class frmNUser : DevExpress.XtraEditors.XtraForm
    {
        private UserBLL userBLL = UserBLL.Instance();
        private bool SU = false;
        public frmNUser()
        {
            InitializeComponent();
        }
        private void Save(bool SU)
        {
            if (userBLL.newUser(new BOL.User { username = txtName.Text.Trim(), password = txtPass.Text.Trim(), SU = SU }))
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
            if (userBLL.checkAvaliable(new BOL.User() { username = this.txtName.Text.Trim() }) == null)
            {
                Message(4);
                return false;
            }
            else
            {
                this.txtName.Focus();
                Message(3);
                return true;
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