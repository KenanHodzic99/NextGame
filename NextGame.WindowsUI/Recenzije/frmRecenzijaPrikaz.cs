using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NextGame.Models.Requests.Recenzija;

namespace NextGame.WindowsUI.Recenzije
{
    public partial class frmRecenzijaPrikaz : Form
    {
        private APIService _service = new APIService("Recenzija");
        private APIService _serviceKorisnik = new APIService("Korisnik");
        private APIService _serviceIgrica = new APIService("Igrica");

        public frmRecenzijaPrikaz()
        {
            InitializeComponent();
        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvObjava.DataSource = null;

            if (!string.IsNullOrWhiteSpace(txtIgra.Text) || !string.IsNullOrWhiteSpace(txtKorisnik.Text))
            {
                RecenzijaSearchRequest request = new RecenzijaSearchRequest();
                if (!string.IsNullOrWhiteSpace(txtIgra.Text))
                {
                    var Igrica = await _serviceIgrica.GetAll<Models.Igrica>(new Models.Requests.Igrica.IgricaSearchRequest() { Naziv = txtIgra.Text });
                    request.igricaId = Igrica.Id;
                }

                if(!string.IsNullOrWhiteSpace(txtKorisnik.Text))
                {
                    var Korisnik = await _serviceIgrica.GetAll<Models.Korisnik>(new Models.Requests.Korisnik.KorisnikSearchRequest() { Username = txtKorisnik.Text });
                    request.korisnikId = Korisnik.Id;
                }

                var Recenzije = await _service.GetAll<List<Models.Recenzija>>(request);
                dgvObjava.DataSource = Recenzije.Where(x=>x.IsPrijavljena==true).ToList();
            }
            else
            {
                var Recenzije = await _service.GetAll<List<Models.Recenzija>>(null);
                dgvObjava.DataSource = Recenzije.Where(x => x.IsPrijavljena == true).ToList();
            }
        }

        private void dgvObjava_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvObjava.Rows[e.RowIndex].DataBoundItem;

            frmRecenzijaDetalji frm = new frmRecenzijaDetalji(item as Models.Recenzija);
            frm.ShowDialog();
        }
    }
}
