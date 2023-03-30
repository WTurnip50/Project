using BLL;
using BOL;
using DevExpress.XtraEditors;
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
    public partial class frmAddMovie : DevExpress.XtraEditors.XtraForm
    {
        private MovieBLL movieBLL = MovieBLL.Instance();
        private WriterBLL writerBLL = WriterBLL.Instance();
        private DirectorBLL directorBLL = DirectorBLL.Instance();
        private ProducerBLL producerBLL = ProducerBLL.Instance();
        private int idMovie = 0;
        private int idW = 0, idD = 0, idP = 0;
        private bool edit = false;
        public frmAddMovie()
        {
            InitializeComponent();
            
        }

        public frmAddMovie(int id)
        {
            InitializeComponent();
            this.idMovie = id;
            Movie movie = movieBLL.GetByID(new BOL.Movie() { idMovie = this.idMovie });
            this.idW = movie.idMovie;
            this.idD = movie.idDirector;
            this.idP = movie.idProducer;
            this.Text = "-- Editar Película -- ";
            this.rlupDirector.ItemIndex = 2;
            this.txtTitle.Text = movie.title;
            this.edit = true;
        }

        private void frmAddMovie_Load(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        private void frmAddMovie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!edit)
            {
                if(XtraMessageBox.Show("¿Desea cerrar el formulario?","Aviso",MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarRegistros()
        {
            rlupWriter.Properties.DataSource = writerBLL.GetAll();
            rlupDirector.Properties.DataSource = directorBLL.GetAll();
            rlupProducer.Properties.DataSource = producerBLL.GetAll();
            rlupWriter.ItemIndex = this.idW;
            rlupDirector.ItemIndex = this.idD;
            rlupProducer.ItemIndex = this.idP;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEdit(this.edit);
        }

        private void SaveEdit(bool edit)
        {
            int idW = (int)rlupWriter.EditValue;
            int idD = (int)rlupDirector.EditValue;
            int idP = (int)rlupProducer.EditValue;
            string title = txtTitle.Text.Trim();
            if (!edit)
            {
                if (title.Equals(""))
                {
                    XtraMessageBox.Show("El campo de texto se encuentra vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtTitle.Focus();
                }
                else
                {
                    if (movieBLL.Add(new BOL.Movie()
                    {
                        idWriter = idW,
                        idDirector = idD,
                        idProducer = idP,
                        title = title
                    }))
                    {
                        XtraMessageBox.Show("Elemento almacenado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (title.Equals(""))
                {
                    XtraMessageBox.Show("El campo de texto se encuentra vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtTitle.Focus();
                }
                else
                {
                    if (movieBLL.Edit(new BOL.Movie()
                    {
                        idMovie = this.idMovie,
                        idWriter = idW,
                        idDirector = idD,
                        idProducer = idP,
                        title = title
                    }))
                    {
                        XtraMessageBox.Show("Elemento actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}