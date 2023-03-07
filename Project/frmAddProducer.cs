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
    public partial class frmAddProducer : Form
    {
        private ProducerBLL producerBLL = ProducerBLL.Instance();

        public frmAddProducer()
        {
            InitializeComponent();
        }
        public frmAddProducer(int id)
        {
            InitializeComponent();
            //txtName.DataSource = producerBLL.GetAll();
            Producer producer = producerBLL.GetByID(new BOL.Producer {
                idProducer = id
            });

            txtName.Text = producer.name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.Equals(""))
            {
                if (producerBLL.Add(new BOL.Producer()
                {
                    name = txtName.Text
                }))
                {
                    MessageBox.Show("Productor almacenado",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El campo nombre no puede ser nulo", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAddProducer_Load(object sender, EventArgs e)
        {

        }
    }
}
