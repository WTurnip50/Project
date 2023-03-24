using BLL;
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
    public partial class frmMovies : DevExpress.XtraEditors.XtraForm
    {
        private MovieBLL movieBLL = MovieBLL.Instance();
        private WriterBLL writerBLL = WriterBLL.Instance();
        private DirectorBLL directorBLL = DirectorBLL.Instance();
        private ProducerBLL producerBLL = ProducerBLL.Instance();
        public frmMovies()
        {
            InitializeComponent();
        }

        private void frmMovies_Load(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        private void CargarRegistros()
        {
            gcMovies.DataSource = movieBLL.GetAll();
            gvMovies.BestFitColumns();
            rlupWriter.DataSource = writerBLL.GetAll();
            rlupDirector.DataSource = directorBLL.GetAll();
            rlupProducer.DataSource = producerBLL.GetAll();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CargarRegistros();
            XtraMessageBox.Show("Registros Cargados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddMovie frm = new frmAddMovie();
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = (int)gvMovies.GetFocusedRowCellValue(colidMovie);
            XtraMessageBox.Show("El valor es: " + row, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmAddMovie frm = new frmAddMovie(row);
            frm.ShowDialog();
        }
    }
}