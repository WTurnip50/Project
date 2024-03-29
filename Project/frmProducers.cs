﻿using BLL;
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
    public partial class frmProducers : Form
    {
        private ProducerBLL producerBLL = ProducerBLL.Instance();

        public frmProducers()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarRegistros();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProducer frm = new frmAddProducer();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dgvProducers.CurrentRow;

            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                //MessageBox.Show("id: " + id);
                frmAddProducer frm = new frmAddProducer(id);
                frm.ShowDialog();
            }
        }

        private void frmProducers_Load(object sender, EventArgs e)
        {
            CargarRegistros();

        }

        private void CargarRegistros()
        {
            dgvProducers.DataSource = producerBLL.GetAll();
        }
    }
}
