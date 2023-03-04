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
    public partial class frmMenu : Form { 
    

        public frmMenu()
        {
            InitializeComponent();
            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Deséa finalizar la sesión?", Application.ProductName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                //Busca el formulario de Login para poder habilitarlo de nuevo.
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(frmLogin))
                    {
                        MessageBox.Show("Sesión Finalizada.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.Show();
                        break;
                    }
                }
            }
           
        }

        private void btnFile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
