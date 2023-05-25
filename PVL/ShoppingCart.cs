using BML;
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
        private int idUser = 0;
        public ShoppingCart()
        {
            InitializeComponent();
        }
        public ShoppingCart(int id)
        {
            InitializeComponent();
            this.idUser = id;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            decimal precio = (decimal)gvCart.GetFocusedRowCellValue(colprecio);
            decimal total = 0;
            for (int i = 0; i < gvCart.RowCount; i++)
            {
                total += decimal.Parse(gvCart.GetRowCellValue(i, colprecio).ToString());
            }
            MessageBox.Show("total: " + total);
            Sale sale = new Sale(idUser, total);
            if(sale.ShowDialog() == DialogResult.OK)
            {
                if(new Cart() { idUser = this.idUser }.EmptyCart() > 0)
                {
                    this.Dispose();
                }
            }
            
        }

        private void CargarCarrito()
        {
           gcCart.DataSource = new Cart().GetAll();
           lupUser.DataSource = new User().GetAll();
           lupMovie.DataSource = new Pelicula().GetAll();
           gvCart.BestFitColumns();
        }
        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            CargarCarrito();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row = (int)gvCart.GetFocusedRowCellValue(colidCart);
            if(new Cart() { idCart = row }.Delete() > 0)
            {
                XtraMessageBox.Show("Retirada del carrito", Application.ProductName, MessageBoxButtons.OK);
            }
        }
    }
}