using BLL;
using BOL;
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
    public partial class frmAddMovie : Form
    {
        private MovieBLL movieBLL = MovieBLL.Instance();
        private WriterBLL writerBLL = WriterBLL.Instance();
        private ProducerBLL producerBLL = ProducerBLL.Instance();
        private DirectorBLL directorBLL = DirectorBLL.Instance();

        private int id = 0;
        //private bool edit = false;
        public frmAddMovie()
        {
            InitializeComponent();
            cbW.DataSource = writerBLL.GetAll();

            cbD.DataSource = directorBLL.GetAll();

            cbP.DataSource = producerBLL.GetAll();
        }
        public frmAddMovie(int id)
        {
            InitializeComponent();
            cbW.DataSource = writerBLL.GetAll();

            cbD.DataSource = directorBLL.GetAll();

            cbP.DataSource = producerBLL.GetAll();
            Movie movie = movieBLL.GetByID(new BOL.Movie()
            {
                idMovie = id
            });
            this.id = movie.idMovie;
            txtTitle.Text = movie.title;
            int idw = movie.idWriter - 1;
            cbW.SelectedIndex = idw;

            int idD = movie.idDirector - 1;
            cbD.SelectedIndex = idD;

            int idp = movie.idProducer - 1;
            cbP.SelectedIndex = idp;
                //cbP.SelectedIndex = movie.idProducer;
                //cbD.SelectedIndex = movie.idDirector;
            }

        private void frmAddMovie_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cb1 = (int) cbW.SelectedValue;
            int cb2 = (int)cbD.SelectedValue;
            int cb3 = (int)cbP.SelectedValue;

            if (!txtTitle.Text.Equals("")) {
                if(movieBLL.Add(new BOL.Movie() {
                    title = txtTitle.Text,
                    idWriter = cb1,
                    idDirector = cb2,
                    idProducer = cb3
                }))
                {
                    MessageBox.Show("Pelicula almacenada",
                   Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El campo categoria no puede ser nulo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
