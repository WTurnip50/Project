using BLL;
using DevExpress.XtraEditors;
using PVL.Tools;
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
    public partial class frmProducer : DevExpress.XtraEditors.XtraForm
    {
        private ProducerBLL producerBLL = ProducerBLL.Instance();
        public frmProducer()
        {
            InitializeComponent();
        }

        private void load()
        {
            gcProducer.DataSource = producerBLL.GetAll();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNewProducer frm = new frmNewProducer();
            frm.ShowDialog();
            load();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = (int)gvProducer.GetFocusedRowCellValue(colidProducer);
            frmNewProducer frm = new frmNewProducer(row);
            frm.ShowDialog();
            load();
        }

        private void btnDrop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = (int)gvProducer.GetFocusedRowCellValue(colidProducer);
            if (XtraMessageBox.Show("¿Desea eliminar al productor?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                XtraMessageBox.Show("Elemento eliminado","Accion exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void frmProducer_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}