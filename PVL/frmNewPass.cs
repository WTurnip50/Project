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
    public partial class frmNewPass : DevExpress.XtraEditors.XtraForm
    {
        private UserBLL userBLL = UserBLL.Instance();
        private int id = 0;
        private bool Find = false;
        public frmNewPass()
        {
            InitializeComponent();
            this.btnSave.Text = "Buscar";
        }

        private void Message(int code)
        {
            switch (code)
            {
                case 1:
                    XtraMessageBox.Show("Usuario encontrado.","Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtPass.Visible = true;
                    this.txtPass2.Visible = true;
                    this.txtName.Enabled = false;
                    break;
                case 2:
                    XtraMessageBox.Show("Usuario no encontrado.\n verifique el nombre", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtName.Focus();
                    break;
                case 3:
                    XtraMessageBox.Show("Cambio realizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    XtraMessageBox.Show("Las contraseñas no coinciden.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Focus();
                    txtPass.Text = "";
                    txtPass2.Text = "";
                    break;
                default:
                    XtraMessageBox.Show("Mensaje por defecto.");
                    break;

            }
        }
        private void find()
        {
            User user = userBLL.checkAvaliable(new BOL.User() { username = txtName.Text.Trim() });
            if (user!=null) {
                this.Find = true;
                this.id = user.idUser;
                Message(1);
            }
        }
        private void frmNewPass_Load(object sender, EventArgs e)
        {
            this.txtPass.Visible = false;
            this.txtPass2.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Find)
            {
                find();
                if (this.Find)
                    this.btnSave.Text = "Guardar cambio";

            }
            else
            {
                if (txtPass.Text.Trim().Equals(txtPass2.Text.Trim()))
                {
                    if(XtraMessageBox.Show("Desea realizar los cambios","Advertencia",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        if (userBLL.newPassword(new BOL.User() { username = txtName.Text.Trim(),
                            idUser = this.id, password = txtPass.Text.Trim() })) {
                            Message(3);
                            this.Close();
                        }
                    }
                }
                else
                {
                    Message(4);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}