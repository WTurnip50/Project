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
    public partial class Sale : DevExpress.XtraEditors.XtraForm
    {
        private int idUser = 0;
        private decimal subtotal = 0;
        private decimal total = 0;
        private bool Pay = false;
        public Sale()
        {
            InitializeComponent();
        }
        public Sale(int idUser, decimal total)
        {
            InitializeComponent();
            this.subtotal = total;
            this.idUser = idUser;
            this.lblSubtotal.Text = "" + this.subtotal;
            this.lblTotal.Visible = false;
            this.txtEfectivo.Enabled = false;
        }

        private void Sale_Load(object sender, EventArgs e)
        {

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (!Pay)
            {
                if (!txtDescuento.Text.Trim().Equals(""))
                {
                    decimal discount = decimal.Parse(txtDescuento.EditValue.ToString());
                    decimal price = this.subtotal * discount;
                    this.total = subtotal - price;
                    this.lblTotal.Text = "" + this.total;
                    lblTotal.Visible = true;
                    this.Pay = true;
                    this.txtDescuento.Enabled = false;
                    this.txtEfectivo.Enabled = true;
                    this.txtEfectivo.Focus();
                    return;
                }
                XtraMessageBox.Show("El campo no puede estar vacio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!txtEfectivo.Text.Trim().Equals(""))
                {
                    if(new Sales() {idUser = this.idUser, total = this.total, fecha = DateTime.Now }.Add()>0)
                    {
                        XtraMessageBox.Show("Venta exitosa",Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            
        }
    }
}