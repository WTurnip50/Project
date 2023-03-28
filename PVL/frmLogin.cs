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
            if(userBLL.Login(new BOL.User() { username = txtUser.Text.Trim(),password = txtPass.Text.Trim() }) != null)
            {
                XtraMessageBox.Show("Bienvenido: " + txtUser.Text, "Inicio de sesión", MessageBoxButtons.OK);
                this.Hide();
                frmMenu frm = new frmMenu();
                frm.Show();
            }
            else
            {
                XtraMessageBox.Show("Credenciales incorrectas", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}