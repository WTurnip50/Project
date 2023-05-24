using BML;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace PVL
{
    public partial class frmAddMovie : DevExpress.XtraEditors.XtraForm
    {
        private int idMovie = 0;
        private int idW = 0, idD = 0, idP = 0;
        private bool edit = false;
        public frmAddMovie()
        {
            InitializeComponent();

        }

        public frmAddMovie(int id)
        {
            InitializeComponent();
            this.idMovie = id;
            this.btnSave.Text = "Actualizar";
            Pelicula movie = new Pelicula() { idMovie = this.idMovie }.GetByID();
            this.idW = movie.idWriter -1;
            this.idD = movie.idDirector -1;
            this.idP = movie.idProducer -1;
            this.Text = "-- Editar Película -- ";
            this.txtTitle.Text = movie.title;
            this.edit = true;
        }

        private void frmAddMovie_Load(object sender, EventArgs e)
        {
            CargarRegistros();
        }
        private void Message(int switch_on)
        {
            switch (switch_on)
            {
                case 1:
                    XtraMessageBox.Show("Elemento almacenado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    XtraMessageBox.Show("El campo de texto se encuentra vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtTitle.Focus();
                    break;
                case 3:
                    XtraMessageBox.Show("Elemento actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    XtraMessageBox.Show("Error en la operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }
        private void frmAddMovie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!edit)
            {
                if (XtraMessageBox.Show("¿Desea cerrar el formulario?", "Aviso", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarRegistros()
        {
            rlupWriter.Properties.DataSource = new Writer().GetAll();
            rlupDirector.Properties.DataSource = new Director().GetAll();
            rlupProducer.Properties.DataSource = new Producer().GetAll();
            rlupWriter.ItemIndex = this.idW;
            rlupDirector.ItemIndex = this.idD;
            rlupProducer.ItemIndex = this.idP;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEdit(this.edit);
        }

        private void SaveEdit(bool edit)
        {
            int idW = (int)rlupWriter.EditValue;
            int idD = (int)rlupDirector.EditValue;
            int idP = (int)rlupProducer.EditValue;

            if (!edit)
            {
                if (txtTitle.Text.Trim().Equals(""))
                {
                    Message(2);
                }
                else
                {
                    if (new Pelicula()
                    {
                        idWriter = idW,
                        idDirector = idD,
                        idProducer = idP,
                        title = txtTitle.Text.Trim(),
                        precio = decimal.Parse(txtPrecio.Text)
                    }.Add() > 0)
                    {
                        Message(1);
                    }
                }
            }
            else
            {
                if (txtTitle.Text.Trim().Equals(""))
                {
                    Message(2);
                }
                else
                {
                    if (new Pelicula()
                    { idMovie = this.idMovie,
                        title = txtTitle.Text.Trim(),
                        idProducer = idP,
                        idDirector = idD,
                        idWriter = idW,
                        precio = decimal.Parse(txtPrecio.Text) 
                    }.Update() > 0)
                    {
                        Message(3);
                    }
                    else
                    {
                        Message(4);
                    }
                }
            }
        }
    }
}
