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


        private void frmMovies_Load(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        private void CargarRegistros()
        {
            dgvMovies.DataSource = movieBLL.GetAll();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddMovie frm = new frmAddMovie();
            frm.ShowDialog();
            CargarRegistros();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dgvMovies.CurrentRow.Cells[0];

            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                int id = Convert.ToInt32(filaSeleccionada.Value);
                frmAddMovie frm = new frmAddMovie(id);
                frm.ShowDialog();
                CargarRegistros();
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dgvMovies.CurrentRow.Cells[0];

            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                if (MessageBox.Show("¿Desea dar de baja la pélicula?", "-- Dar de baja --",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    int id = Convert.ToInt32(filaSeleccionada.Value);
                    if (movieBLL.Disable(new BOL.Movie()
                    {
                        idMovie = id
                    }))
                    {
                        MessageBox.Show("Pelicula dada de baja", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarRegistros();
                    }
                }
                else
                {
                    MessageBox.Show("Operación Cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}
