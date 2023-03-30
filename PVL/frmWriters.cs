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
    public partial class frmWriters : DevExpress.XtraEditors.XtraForm
    {
        private WriterBLL writerBLL = WriterBLL.Instance();
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
            gcWriter.DataSource = writerBLL.GetAll();
        }
        private void Add()
        {
            frmAddWriter frmAddWriter = new frmAddWriter();
            frmAddWriter.ShowDialog();
        }

        private void Edit()
        {
            int row = (int)gvWriter.GetFocusedRowCellValue(colidWriter);
            XtraMessageBox.Show("El valor es: " + row, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (writerBLL.Disable(new BOL.Writer() { idWriter = row }))
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
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit();
        }

        private void btnDrop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Drop();
        }
    }
}