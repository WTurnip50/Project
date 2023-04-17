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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private UserBLL userBLL = UserBLL.Instance(); 
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = userBLL.Login(new BOL.User() { username = txtUser.Text.Trim(), password = txtPass.Text.Trim() });
            if(user!= null)
            {
                XtraMessageBox.Show("Bienvenido: " + txtUser.Text, "Inicio de sesión", MessageBoxButtons.OK);
                this.txtPass.Text = "";
                this.txtUser.Text = "";
                this.txtUser.Focus();
                this.Hide();
                frmMenu frm = new frmMenu(user.SU);
                frm.Show();
            }
            else
            {
                XtraMessageBox.Show("Credenciales incorrectas", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}