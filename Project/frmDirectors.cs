using BLL;
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
    public partial class frmDirectors : Form
    {
        private DirectorBLL directorBLL = DirectorBLL.Instance();
        public frmDirectors()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        private void frmDirectors_Load(object sender, EventArgs e)
        {
            CargarRegistros();

        }

        private void CargarRegistros()
        {
            dgvDirecctors.DataSource = directorBLL.GetAll();
        }
    }
}
