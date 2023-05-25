using BML;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace PVL
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        //private UserBLL userBLL = UserBLL.Instance(); 
        SplashScreenManager sm = new SplashScreenManager();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User() { username = this.txtUser.Text.Trim(), password = txtPass.Text.Trim()}.Login();
            if(user!= null)
            {
                XtraMessageBox.Show("Bienvenido: " + txtUser.Text, "Inicio de sesión", MessageBoxButtons.OK);
                this.txtPass.Text = "";
                this.txtUser.Text = "";
                this.txtUser.Focus();
                sm.ShowWaitForm();
                this.Hide();
                sm.CloseWaitForm();
                frmMenu frm = new frmMenu(user.SU, user.idUser);
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

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            
        }
    }
}