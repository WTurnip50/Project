using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmLogin : Form
    {
        private bool cambio = false;
        private bool logged = false;
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
            if(!txtUser.Text.Equals("") && !txtPass.Text.Equals(""))
            {
                User user = userBLL.Login(new BOL.User()
                {
                    username = txtUser.Text,
                    password = txtPass.Text
                });
                if(user != null)
                {
                    MessageBox.Show("Bienvenido: " + user.username, Application.ProductName,
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Clean();
                    //DialogResult = DialogResult.OK;
                    //logged = true;
                    this.Hide();
                    frmSplash frm = new frmSplash();
                    frm.ShowDialog();
                    frmMenu frmMenu = new frmMenu();
                    frmMenu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", Application.ProductName,
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Clean();
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos.", Application.ProductName,
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Clean()
        {
            txtPass.Text = "";
            txtUser.Text = "";
            txtUser.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            validarCambio();
            if (!logged)
            {
                if (!cambio)
                {
                    if (MessageBox.Show("Desea cerrar el formulario", Application.ProductName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro de continuar la operación?", Application.ProductName,
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        e.Cancel = true;
                        cambio = false;
                        txtUser.Focus();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validarCambio()
        {
            if (!txtPass.Text.Equals("") || !txtUser.Text.Equals(""))
            {
                cambio = true;
            }
        }
    }
}
