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
    public partial class frmAddWriter : Form
    {
        private WriterBLL writerBLL = WriterBLL.Instance();
        public frmAddWriter()
        {
            InitializeComponent();
        }

        public frmAddWriter(int id)
        {
            InitializeComponent();
            //Writer writer = writerBLL.GetByID(new BOL.Writer
            //{
            //    idWriter = id;
            //});
            
        }

        private void frmAddWriter_Load(object sender, EventArgs e)
        {

        }
    }
}
