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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tmsplash_Tick(object sender, EventArgs e)
        {
            this.tmsplash.Enabled = true;

            this.pbSplash.Increment(2);

            if(this.pbSplash.Value == 100)
            {
                this.tmsplash.Enabled = false;
                //frmMenu frm = new frmMenu();
                //frm.Show();
                this.Dispose();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
