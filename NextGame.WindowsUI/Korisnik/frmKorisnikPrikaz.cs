using NextGame.Models.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NextGame.WindowsUI.Korisnik
{
    public partial class frmKorisnikPrikaz : Form
    {
        private APIService _service = new APIService("Korisnik");
        public frmKorisnikPrikaz()
        {
            InitializeComponent();
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvKorisnici.DataSource = null;

            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                KorisnikSearchRequest request = new KorisnikSearchRequest()
                {
                   Username=txtUsername.Text
                };

                dgvKorisnici.DataSource = await _service.GetAll<List<Models.Korisnik>>(request);
            }
            else
            {
                dgvKorisnici.DataSource = await _service.GetAll<List<Models.Korisnik>>(null);
            }
        }

        private void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisnici.Rows[e.RowIndex].DataBoundItem;

            frmKorisnikDodaj frm = new frmKorisnikDodaj(item as Models.Korisnik);
            frm.ShowDialog();
        }

        private void frmKorisnikPrikaz_Load(object sender, EventArgs e)
        {

        }
    }
}
