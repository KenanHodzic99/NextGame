using NextGame.Models.Requests.IzdavackaKuca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NextGame.WindowsUI.IzdavackaKuca
{
    public partial class frmIzdavackaKucaDodaj : Form
    {
        private APIService _service = new APIService("IzdavackaKuca");
        private Models.IzdavackaKuca _entity;
        private bool isUcitana = false;
        public frmIzdavackaKucaDodaj(Models.IzdavackaKuca entity = null)
        {
            InitializeComponent();
            _entity = entity;
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            if (ofdSlika.ShowDialog() == DialogResult.OK)
            {
                pbIzdavackaKuca.ImageLocation = ofdSlika.FileName;
                isUcitana = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_entity != null)
            {
                IzdavackaKucaUpdateRequest request = new IzdavackaKucaUpdateRequest() 
                {
                    Sjediste = txtSjediste.Text,
                    BrojZaposlenika = Convert.ToInt32(nudBrojZaposlenika.Value),
                    DatumOsnivanja = dtpOsnivanja.Value,
                    MjestoOsnivanja = txtMjestoOsnivanja.Text,
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text,
                    Osnivaci = txtOsnivaci.Text
                };
                if (isUcitana)
                {
                    request.Slika = System.IO.File.ReadAllBytes(pbIzdavackaKuca.ImageLocation);
                    var result = await _service.Update<Models.IzdavackaKuca>(_entity.Id, request);
                    if(MessageBox.Show("Uspjesno ste ažurirali izdavačku kuću!", "Izdavačka kuća") == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                 
                    request.Slika = _entity.Slika;
                    

                    var result = await _service.Update<Models.IzdavackaKuca>(_entity.Id, request);
                    if (MessageBox.Show("Uspjesno ste ažurirali izdavačku kuću!", "Izdavačka kuća") == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                if (isUcitana)
                {
                    IzdavackaKucaInsertRequest request = new IzdavackaKucaInsertRequest()
                    {
                        Sjediste = txtSjediste.Text,
                        BrojZaposlenika = Convert.ToInt32(nudBrojZaposlenika.Value),
                        DatumOsnivanja = dtpOsnivanja.Value,
                        MjestoOsnivanja = txtMjestoOsnivanja.Text,
                        Naziv = txtNaziv.Text,
                        Opis = txtOpis.Text,
                        Osnivaci = txtOsnivaci.Text
                    };
                    request.Slika = System.IO.File.ReadAllBytes(pbIzdavackaKuca.ImageLocation);
                    MessageBox.Show("Uspjesno ste dodali izdavačku kuću!", "Izdavačka kuća");
                    var result = await _service.Insert<Models.IzdavackaKuca>(request);
                }
                else
                {
                    MessageBox.Show("Obavezan odabir slike!", "Upozorenje");
                }
            }
        }

        private void frmIzdavackaKucaDodaj_Load(object sender, EventArgs e)
        {
            if (_entity != null)
            {
                txtSjediste.Text = _entity.Sjediste;
                pbIzdavackaKuca.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(Convert.ToBase64String(_entity.Slika))));
                nudBrojZaposlenika.Value = _entity.BrojZaposlenika;
                dtpOsnivanja.Value = _entity.DatumOsnivanja;
                txtMjestoOsnivanja.Text = _entity.MjestoOsnivanja;
                txtNaziv.Text = _entity.Naziv;
                txtOpis.Text = _entity.Opis;
                txtOsnivaci.Text = _entity.Osnivaci;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
                epNaziv.SetError(txtNaziv, Properties.Resources.ObavezanUnosPolja);
            else
                epNaziv.Clear();
        }

        private void nudBrojZaposlenika_Validating(object sender, CancelEventArgs e)
        {
            if (nudBrojZaposlenika.Value<0||nudBrojZaposlenika.Value==0)
                epBrojZaposlenika.SetError(nudBrojZaposlenika, Properties.Resources.ObavezanUnosPolja);
            else
                epBrojZaposlenika.Clear();
        }

        private void txtOsnivaci_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOsnivaci.Text))
                epOsnivaci.SetError(txtOsnivaci, Properties.Resources.ObavezanUnosPolja);
            else
                epOsnivaci.Clear();
        }

        private void txtMjestoOsnivanja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMjestoOsnivanja.Text))
                epMjestoOsnivanja.SetError(txtMjestoOsnivanja, Properties.Resources.ObavezanUnosPolja);
            else
                epMjestoOsnivanja.Clear();
        }

        private void txtSjediste_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSjediste.Text))
                epSjediste.SetError(txtSjediste, Properties.Resources.ObavezanUnosPolja);
            else
                epSjediste.Clear();
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
