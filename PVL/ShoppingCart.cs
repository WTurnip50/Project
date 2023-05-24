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
    public partial class ShoppingCart : DevExpress.XtraEditors.XtraForm
    {
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.ShowDialog();
            //Desactivar registros carrito
            this.Dispose();
        }
    }
}