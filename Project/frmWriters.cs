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
    public partial class frmWriters : Form
    {
        private WriterBLL writerBLL = WriterBLL.Instance();

        public frmWriters()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddWriter frm = new frmAddWriter();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dgvWriters.CurrentRow;

            if(filaSeleccionada != null)
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                frmAddWriter frm = new frmAddWriter(id);
                frm.ShowDialog();
            }
        }

        private void CargarRegistros()
        {
            dgvWriters.DataSource = writerBLL.GetAll();
        }

        private void frmWriters_Load(object sender, EventArgs e)
        {
            CargarRegistros();
        }
    }
}
