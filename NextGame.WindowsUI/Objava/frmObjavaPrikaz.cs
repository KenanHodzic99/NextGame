using NextGame.Models.Requests.Objava;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NextGame.WindowsUI.Objava
{
    public partial class frmObjavaPrikaz : Form
    {
        private APIService _service = new APIService("Objava");
        public frmObjavaPrikaz()
        {
            InitializeComponent();
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvObjava.DataSource = null;

            if (!string.IsNullOrWhiteSpace(txtIgra.Text) || !string.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                ObjavaSearchRequest request = new ObjavaSearchRequest()
                {
                    Igrica = txtIgra.Text,
                    Naslov = txtNaslov.Text
                };

                dgvObjava.DataSource = await _service.GetAll<List<Models.Objava>>(request);
            }
            else
            {
                dgvObjava.DataSource = await _service.GetAll<List<Models.Objava>>(null);
            }
        }

        private void dgvObjava_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvObjava.Rows[e.RowIndex].DataBoundItem;

            frmObjavaDodaj frm = new frmObjavaDodaj(item as Models.Objava);
            frm.ShowDialog();
        }

        private void frmObjavaPrikaz_Load(object sender, EventArgs e)
        {

        }
    }
}
