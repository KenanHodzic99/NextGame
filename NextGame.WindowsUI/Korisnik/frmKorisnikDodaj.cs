using NextGame.Models.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NextGame.WindowsUI.Korisnik
{
    public partial class frmKorisnikDodaj : Form
    {
        private APIService _service = new APIService("Korisnik");
        private APIService _ulogaService = new APIService("Uloga");
        private Models.Korisnik _entity;
        private bool isUcitana = false;
        public frmKorisnikDodaj(Models.Korisnik entity = null)
        {
            InitializeComponent();
            _entity = entity;
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            if (ofdSlika.ShowDialog() == DialogResult.OK)
            {
                pbSlika.ImageLocation = ofdSlika.FileName;
                isUcitana = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtPassword2.Text)
            {
                if (MessageBox.Show("Passwordi nisu isti!", "Upozorenje") == DialogResult.OK)
                    return;
            }

            var ulogeList = clbUloge.CheckedItems.Cast<Models.Uloga>();
            var ulogeIdList = ulogeList.Select(x => x.Id).ToList();

            if (_entity != null)
            {
                KorisnikUpdateRequest request = new KorisnikUpdateRequest()
                {
                    UlogeId = ulogeIdList,
                    Password = null,
                    DatumRođenja = dtpDatumRodenja.Value,
                    Opis = txtOpis.Text
                };
                if (isUcitana)
                {
                    request.Slika = System.IO.File.ReadAllBytes(pbSlika.ImageLocation);
                    var result = await _service.Update<Models.Korisnik>(_entity.Id, request);
                    if (MessageBox.Show("Uspjesno ste ažurirali korisnika!", "Korisnik") == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {

                    request.Slika = _entity.Slika;
                    var result = await _service.Update<Models.Korisnik>(_entity.Id, request);
                    if (MessageBox.Show("Uspjesno ste ažurirali korisnika!", "Korisnik") == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                if (isUcitana)
                {
                    KorisnikInsertRequest request = new KorisnikInsertRequest()
                    {
                        DatumRođenja = dtpDatumRodenja.Value,
                        Opis = txtOpis.Text,
                        Password = txtPassword.Text,
                        Username = txtUsername.Text,
                        UlogeId = ulogeIdList
                    };
                    request.Slika = System.IO.File.ReadAllBytes(pbSlika.ImageLocation);
                    MessageBox.Show("Uspjesno ste dodali korisnika", "Korisnik");
                    var result = await _service.Insert<Models.Korisnik>(request);
                }
                else
                {
                    MessageBox.Show("Obavezan odabir slike!","Upozorenje");
                }
            }
        }

        private async void frmKorisnikDodaj_Load(object sender, EventArgs e)
        {
            clbUloge.DataSource = await _ulogaService.GetAll<List<Models.Uloga>>(null);
            clbUloge.DisplayMember = "Naziv";

            if (_entity != null)
            {
                
                if (_entity.DatumRođenja.ToString() != "1. 1. 0001. 00:00:00")
                {
                    dtpDatumRodenja.Value = _entity.DatumRođenja;
                }

                txtOpis.Text = _entity.Opis;
                lblPass1.Visible = false;
                lblPass2.Visible = false;
                txtPassword.Visible = false;
                txtPassword2.Visible = false;
                txtUsername.Text = _entity.Username;
                txtUsername.ReadOnly = true;
                pbSlika.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(Convert.ToBase64String(_entity.Slika))));
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                epUsername.SetError(txtUsername, Properties.Resources.ObavezanUnosPolja);
            else
                epUsername.Clear();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                epPassword1.SetError(txtPassword, Properties.Resources.ObavezanUnosPolja);
            else
                epPassword1.Clear();
        }

        private void txtPassword2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword2.Text))
                epPassword2.SetError(txtPassword2, Properties.Resources.ObavezanUnosPolja);
            else if(!txtPassword.Text.Equals(txtPassword2.Text))
                epPassword2.SetError(txtPassword2,"Passwordi nisu isti!");
            else
                epPassword2.Clear();
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
                epOpis.SetError(txtOpis, Properties.Resources.ObavezanUnosPolja);
            else
                epOpis.Clear();
        }
    }
}
