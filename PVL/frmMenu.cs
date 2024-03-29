﻿using DevExpress.XtraEditors;
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
        private void Message(int code) {
            switch (code)
            {
                case 1:
                    XtraMessageBox.Show("No cuenta con permisos avanzados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
        private void btnMovies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMovies frm = new frmMovies();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDirectors_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDirector frm = new frmDirector();
            frm.MdiParent = this;
            frm.Show();
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
            frmWriters frmWriters = new frmWriters();
            frmWriters.MdiParent = this;
            frmWriters.Show();
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
                //frmN.MdiParent = this;
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
    }
}