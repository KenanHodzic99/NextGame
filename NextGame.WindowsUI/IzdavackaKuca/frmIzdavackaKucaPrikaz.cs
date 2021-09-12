using NextGame.Models.Requests.IzdavackaKuca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NextGame.WindowsUI.IzdavackaKuca
{
    public partial class frmIzdavackaKucaPrikaz : Form
    {
        private APIService _service = new APIService("IzdavackaKuca");
        public frmIzdavackaKucaPrikaz()
        {
            InitializeComponent();
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvIzdavackaKuca.DataSource = null;

            if(!string.IsNullOrWhiteSpace(txtMjestoOsnivanja.Text) || !string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                IzdavackaKucaSearchRequest request = new IzdavackaKucaSearchRequest()
                {
                    MjestoOsnivanja = txtMjestoOsnivanja.Text,
                    Naziv = txtNaziv.Text
                };

                dgvIzdavackaKuca.DataSource = await _service.GetAll<List<Models.IzdavackaKuca>>(request);
            }
            else
            {
                dgvIzdavackaKuca.DataSource = await _service.GetAll<List<Models.IzdavackaKuca>>(null);
            }

        }

        private void dgvIzdavackaKuca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvIzdavackaKuca.Rows[e.RowIndex].DataBoundItem;

            frmIzdavackaKucaDodaj frm = new frmIzdavackaKucaDodaj(item as Models.IzdavackaKuca);
            frm.ShowDialog();
        }

        private void frmIzdavackaKucaPrikaz_Load(object sender, EventArgs e)
        {
            dgvIzdavackaKuca.DataSource = null;
        }
    }
}
