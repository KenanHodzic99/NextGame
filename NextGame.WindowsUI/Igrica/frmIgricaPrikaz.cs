using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NextGame.Models.Requests.Igrica;

namespace NextGame.WindowsUI.Igrica
{
    public partial class frmIgricaPrikaz : Form
    {
        private APIService _service = new APIService("Igrica");
        public frmIgricaPrikaz()
        {
            InitializeComponent();
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvIgra.DataSource = null;

            if (!string.IsNullOrWhiteSpace(txtIzdavackaKuca.Text) || !string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                IgricaSearchRequest request = new IgricaSearchRequest()
                {
                    IzdavackaKuca = txtIzdavackaKuca.Text,
                    Naziv = txtNaziv.Text
                };

                dgvIgra.DataSource = await _service.GetAll<List<Models.Igrica>>(request);
            }
            else
            {
                dgvIgra.DataSource = await _service.GetAll<List<Models.Igrica>>(null);
            }
        }

        private void dgvIgra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvIgra.Rows[e.RowIndex].DataBoundItem;

            frmIgricaDodaj frm = new frmIgricaDodaj(item as Models.Igrica);
            frm.ShowDialog();
        }

        private void frmIgricaPrikaz_Load(object sender, EventArgs e)
        {

        }
    }
}
