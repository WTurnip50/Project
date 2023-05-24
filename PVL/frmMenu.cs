using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PVL
{
    public partial class frmMenu : DevExpress.XtraEditors.XtraForm
    {
        private bool SU = false;
        public frmMenu()
        {
            InitializeComponent();
        }
        public frmMenu(bool SU)
        {
            InitializeComponent();
            this.SU = SU;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void MdiParent_MdiChildActivate(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => {
                //...
                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption("Please wait");
                splashScreenManager1.SetWaitFormDescription("iniciando formulario");
                //...
                splashScreenManager1.CloseWaitForm();
            }));
        }
        private void Message(int code)
        {
            switch (code)
            {
                case 1:
                    XtraMessageBox.Show("El usuario no cuenta con permisos avanzados. ", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
        private void btnMovies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMovies);
            if (frmo != null)
            {
                foreach (Form frmOpen in Application.OpenForms)
                {
                    if (frmOpen.GetType() == typeof(frmMovies))
                    {
                        frmOpen.Focus();
                        frmOpen.WindowState = FormWindowState.Maximized;
                        break;
                    }
                }
            }
            else
            {
                frmMovies frm = new frmMovies(this.SU);
                frm.MdiParent = this;
                frm.Show();
            }


        }

        private void btnDirectors_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmDirector);
            if (frmo != null)
            {
                foreach (Form frmOpen in Application.OpenForms)
                {
                    if (frmOpen.GetType() == typeof(frmDirector))
                    {
                        frmOpen.Focus();
                        frmOpen.WindowState = FormWindowState.Maximized;
                        break;
                    }
                }
            }
            else
            {
                frmDirector frm = new frmDirector();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("¿Deséa finalizar la sesión?", Application.ProductName,
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
                        XtraMessageBox.Show("Sesión Finalizada.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm.Show();
                        break;
                    }
                }
            }
        }

        private void btnWriters_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmWriters);
            if (frmo != null)
            {
                foreach (Form frmOpen in Application.OpenForms)
                {
                    if (frmOpen.GetType() == typeof(frmWriters))
                    {
                        frmOpen.Focus();
                        frmOpen.WindowState = FormWindowState.Maximized;
                        break;
                    }
                }
            }
            else
            {
                frmWriters frmWriters = new frmWriters();
                frmWriters.MdiParent = this;
                frmWriters.Show();
            }
            //foreach(Form form in Application.OpenForms)
            //{
            //    if(form.GetType() == typeof(frmWriters))
            //    {
            //        form.Activate();
            //        return;
            //    }
            //}
            //new frmWriters() { MdiParent = this }.Show();
        }

        private void btnNewUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (!this.SU)
            {
                Message(1);
            }
            else
            {
                frmNUser frmN = new frmNUser();
                frmN.ShowDialog();
            }

        }

        private void btnNewPass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.SU)
            {
                Message(1);
            }
            else
            {
                frmNewPass frm = new frmNewPass();
                frm.ShowDialog();
            }

        }

        private void btnProducers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmProducer);
            if (frmo != null)
            {
                foreach (Form frmOpen in Application.OpenForms)
                {
                    if (frmOpen.GetType() == typeof(frmProducer))
                    {
                        frmOpen.Focus();
                        frmOpen.WindowState = FormWindowState.Maximized;
                        break;
                    }
                }
            }
            else
            {
                frmProducer frm = new frmProducer();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}