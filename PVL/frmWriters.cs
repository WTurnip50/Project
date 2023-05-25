using BML;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PVL
{
    public partial class frmWriters : DevExpress.XtraEditors.XtraForm
    {
        public frmWriters()
        {
            InitializeComponent();
        }

        private void frmWriters_Load(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        private void CargarRegistros()
        {
            gcWriter.DataSource = new Writer().GetAll();
        }
        private void Add()
        {
            frmAddWriter frmAddWriter = new frmAddWriter();
            frmAddWriter.ShowDialog();
            CargarRegistros();
        }

        private void Edit()
        {
            int row = (int)gvWriter.GetFocusedRowCellValue(colidWriter);
            frmAddWriter frm = new frmAddWriter(row);
            frm.ShowDialog();
        }

        private void Drop()
        {
            int row = (int)gvWriter.GetFocusedRowCellValue(colidWriter);
            if (XtraMessageBox.Show("Desea eliminar al Director", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                XtraMessageBox.Show("Operación Cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (new Writer(){ idWriter = row }.Delete() > 0)
                {
                    XtraMessageBox.Show("Operación Exitosa", "Aviso", MessageBoxButtons.OK);
                }
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
            CargarRegistros();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit();
            CargarRegistros();
        }

        private void btnDrop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Drop();
            CargarRegistros();
        }
    }
}