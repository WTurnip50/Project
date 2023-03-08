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
        private bool fma = false;

        private bool fwa = false;

        private bool fda = false;
        
        private bool fpa = false;

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

        
 
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            Form frmo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMovies);
            if (frmo != null)
            {
                foreach (Form frmOpen in Application.OpenForms)
                {
                    if (frmOpen.GetType() == typeof(frmMovies))
                    {
                        //MessageBox.Show("Ya esta abierto", "Aviso",
                        //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmOpen.Focus();
                        frmOpen.WindowState = FormWindowState.Maximized;
                        fma = true;
                        break;
                    }
                    else
                    {
                        fma = false;
                    }
                }
            }
            else
            {
                frmMovies frm = new frmMovies();
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void btnWriter_Click(object sender, EventArgs e)
        {
            Form frmo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmWriters);
            if (frmo != null)
            {
                foreach (Form frmOpen in Application.OpenForms)
                {
                    if (frmOpen.GetType() == typeof(frmWriters))
                    {
                        //MessageBox.Show("Ya esta abierto", "Aviso",
                        //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmOpen.Focus();
                        frmOpen.WindowState = FormWindowState.Maximized;
                        break;
                    }
                }
            }
            else
            {
                frmWriters frm = new frmWriters();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnDirectors_Click(object sender, EventArgs e)
        {
            Form frmo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmDirectors);
            if (frmo != null)
            {
                foreach (Form frmOpen in Application.OpenForms)
                {
                    if (frmOpen.GetType() == typeof(frmDirectors))
                    {
                        frmOpen.Focus();
                        frmOpen.WindowState = FormWindowState.Maximized;
                        break;
                    }
                }
            }
            else
            {
                frmDirectors frm = new frmDirectors();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnProducers_Click(object sender, EventArgs e)
        {
            Form frmo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProducers);
            if (frmo != null)
            {
                foreach (Form frmOpen in Application.OpenForms)
                {
                    if (frmOpen.GetType() == typeof(frmProducers))
                    {
                        frmOpen.Focus();
                        frmOpen.WindowState = FormWindowState.Maximized;
                        break;
                    }
                }
            }
            else
            {
                frmProducers frm = new frmProducers();
                frm.MdiParent = this;
                frm.Show();
                fpa = true;
            }
            
        }
        
    }
}
