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
    public partial class frmMovies : Form
    {
        private MovieBLL movieBLL = MovieBLL.Instance();
        public frmMovies()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            CargarRegistros();
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddMovie frm = new frmAddMovie();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dgvMovies.CurrentRow;

            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                //MessageBox.Show("id: " + id);
                frmAddMovie frm = new frmAddMovie(id);
                frm.ShowDialog();
            }


        }

        private void frmMovies_Load(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        private void CargarRegistros()
        {
            dgvMovies.DataSource = movieBLL.GetAll();
        }
    }
}
