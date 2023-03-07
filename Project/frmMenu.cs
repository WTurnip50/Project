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
            if (fma)
            {
                foreach (Form frmo in Application.OpenForms)
                {
                    if (frmo.GetType() == typeof(frmMovies))
                    {
                        MessageBox.Show("Ya esta abierto", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmo.Show();
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
                fma = true;
            }
        }

        private void btnWriter_Click(object sender, EventArgs e)
        {
            if (fwa)
            {
                foreach (Form frmo in Application.OpenForms)
                {
                    if (frmo.GetType() == typeof(frmWriters))
                    {
                        MessageBox.Show("Ya esta abierto", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmo.Show();
                        fwa = true;
                        break;
                    }
                    else
                    {
                        fwa = false;
                    }
                }
            }
            else
            {
                frmWriters frm = new frmWriters();
                frm.MdiParent = this;
                frm.Show();
                fwa = true;
            }
        }

        private void btnDirectors_Click(object sender, EventArgs e)
        {
            if (fda)
            {
                foreach (Form frmo in Application.OpenForms)
                {
                    if (frmo.GetType() == typeof(frmDirectors))
                    {
                        MessageBox.Show("Ya esta abierto", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmo.Show();
                        fda = true;
                        break;
                    }
                    else
                    {
                        fda = false;
                    }
                }
            }
            else
            {
                frmDirectors frm = new frmDirectors();
                frm.MdiParent = this;
                frm.Show();
                fda = true;
            }
        }

        private void btnProducers_Click(object sender, EventArgs e)
        {
            if (fpa)
            {
                foreach (Form frmo in Application.OpenForms)
                {
                    if (frmo.GetType() == typeof(frmProducers))
                    {
                        MessageBox.Show("Ya esta abierto", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmo.Show();
                        fpa = true;
                        break;
                    }
                    else
                    {
                        fpa = false;
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
