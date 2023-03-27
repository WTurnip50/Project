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
    public partial class frmDirector : DevExpress.XtraEditors.XtraForm
    {
        private DirectorBLL directorBLL = DirectorBLL.Instance();

        public frmDirector()
        {
            InitializeComponent();
        }
        private void CargarRegistros()
        {
            gcDirector.DataSource = directorBLL.GetAll();
        }
        private void Add() {
            frmAddDirector frm = new frmAddDirector();
            frm.ShowDialog();
        }


        private void Edit()
        {
            int row = (int)gvDirector.GetFocusedRowCellValue(colidDirector);
            //XtraMessageBox.Show("El valor es: " + row, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmAddDirector frm = new frmAddDirector(row);
            frm.ShowDialog();
        }

        private void Drop()
        {
            int row = (int)gvDirector.GetFocusedRowCellValue(colidDirector);
            if(XtraMessageBox.Show("Desea eliminar al Director", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                XtraMessageBox.Show("Operación Cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(directorBLL.Disable(new BOL.Director() { idDirector = row }))
                {
                    XtraMessageBox.Show("Operación Exitosa", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Registros Cargados", "Aviso",MessageBoxButtons.OK);
            CargarRegistros();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add();
        }

        private void frmDirector_Load(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit();
        }

        private void btnDrop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Drop();
        }

        private void gcDirector_Click(object sender, EventArgs e)
        {

        }
    }
}