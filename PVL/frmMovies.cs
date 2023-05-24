using BML;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace PVL
{
    public partial class frmMovies : DevExpress.XtraEditors.XtraForm
    {

        public frmMovies()
        {
            InitializeComponent();
        }
        public frmMovies(bool su)
        {
            InitializeComponent();
            this.btnEdit.Enabled = su;
            this.btnDrop.Enabled = su;
        }

        private void frmMovies_Load(object sender, EventArgs e)
        {
            CargarRegistros(); 
        }

        private void CargarRegistros()
        {
            //gcMovies.DataSource = movieBLL.GetAll();
            peliculaBindingSource1.DataSource = new Pelicula().GetAll();
            gvMovies.BestFitColumns();
            rlupWriter.DataSource = new Writer().GetAll();
            rlupDirector.DataSource = new Director().GetAll();
            rlupProducer.DataSource = new Producer().GetAll();
        }

        private void Add()
        {
            frmAddMovie frm = new frmAddMovie();
            frm.ShowDialog();
        }

        private void Edit()
        {
            int row = (int)gvMovies.GetFocusedRowCellValue(colidMovie);
            XtraMessageBox.Show("El valor es: " + row, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmAddMovie frm = new frmAddMovie(row);
            frm.ShowDialog();
        }

        private void Dropdown()
        {
            int row = (int)gvMovies.GetFocusedRowCellValue(colidMovie);
            if (row > 0)
            {
                if (XtraMessageBox.Show("Desea Eliminar la pelicula", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.No)
                {
                    if (new Pelicula() { idMovie = row }.Delete() > 0)
                    {
                        XtraMessageBox.Show("Pelicula Eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                        
            }
            else
            {
                    XtraMessageBox.Show("Operación Cancelada","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Registros Cargados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarRegistros();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit();
        }

        private void btnDrop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dropdown();
        }

        private void gcMovies_Click(object sender, EventArgs e)
        {

        }

        private void frmMovies_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            SplashScreenManager.CloseForm();
        }

        private void btnCart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.ShowDialog();
        }
    }
}