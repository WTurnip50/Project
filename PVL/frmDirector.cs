using BML;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PVL
{
    public partial class frmDirector : DevExpress.XtraEditors.XtraForm
    {
        public frmDirector()
        {
            InitializeComponent();
        }
        private void CargarRegistros()
        {
            gcDirector.DataSource = new Director().GetAll();
        }
        private void Message(int switch_on)
        {
            switch (switch_on)
            {
                case 1:
                    XtraMessageBox.Show("Operación Exitosa", "Aviso", MessageBoxButtons.OK);
                    break;
                case 2:
                    XtraMessageBox.Show("Registros Cargados", "Aviso", MessageBoxButtons.OK);
                    break;
                default:
                    break;
            }
        }
        private void Add()
        {
            frmAddDirector frm = new frmAddDirector();
            frm.ShowDialog();
            CargarRegistros();
        }


        private void Edit()
        {
            int row = (int)gvDirector.GetFocusedRowCellValue(colidDirector);
            frmAddDirector frm = new frmAddDirector(row);
            frm.ShowDialog();
        }

        private void Drop()
        {
            int row = (int)gvDirector.GetFocusedRowCellValue(colidDirector);
            if (XtraMessageBox.Show("Desea eliminar al Director", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                XtraMessageBox.Show("Operación Cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (new Director() { idDirector = row }.Delete() > 0)
                {
                    Message(1);
                }
            }
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Message(2);
            CargarRegistros();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add();
            CargarRegistros();
        }

        private void frmDirector_Load(object sender, EventArgs e)
        {
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

        private void gcDirector_Click(object sender, EventArgs e)
        {

        }
    }
}