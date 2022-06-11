using NextGame.Models;
using NextGame.Models.Requests.Igrica;
using NextGame.WindowsUI.Properties;
using NextGame.WindowsUI.System_Requirements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NextGame.WindowsUI.Igrica
{
    public partial class frmIgricaDodaj : Form
    {
        public static Models.SystemRequirements SysReq = new Models.SystemRequirements();
        private APIService _service = new APIService("Igrica");
        private APIService _izdavackaKuceService = new APIService("IzdavackaKuca");
        private APIService _tipService = new APIService("Tip");
        private APIService _zanrService = new APIService("Zanr");

        public Models.Igrica _entity;
        public bool isUcitana = false;
        public frmIgricaDodaj(Models.Igrica entity = null)
        {
            InitializeComponent();
            _entity = entity;
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            if (ofdSlika.ShowDialog() == DialogResult.OK)
            {
                pbIgra.ImageLocation = ofdSlika.FileName;
                isUcitana = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_entity != null)
            {
             
                IgricaUpdateRequest request = new IgricaUpdateRequest()
                {
                    SystemRequirements = SysReq,
                    Cijena = (float)nudCijena.Value,
                    DatumIzdavanja = dtpDatumIzdavanja.Value,
                    IzdavackaKucaId = int.Parse(cbIzdavackaKuca.SelectedValue.ToString()),
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text,
                    Tip = cbTip.SelectedItem as Tip,
                    Zanrovi = (List<Zanr>)clbZanr.CheckedItems.Cast<Models.Zanr>()
                };
                if (isUcitana)
                {
                    request.Slika = System.IO.File.ReadAllBytes(pbIgra.ImageLocation);
                    var result = await _service.Update<Models.Igrica>(_entity.Id, request);
                    if (MessageBox.Show("Uspjesno ste ažurirali izdavačku igricu!", "Igrica") == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    request.Slika = _entity.Slika;
                    var result = await _service.Update<Models.Igrica>(_entity.Id, request);
                    if (MessageBox.Show("Uspjesno ste ažurirali igricu!", "Igrica") == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                if (isUcitana)
                {
                    if (string.IsNullOrWhiteSpace(SysReq.GrafickaKartica) || string.IsNullOrWhiteSpace(SysReq.Memorija) || string.IsNullOrWhiteSpace(SysReq.OperativniSistem) || string.IsNullOrWhiteSpace(SysReq.Procesor) || string.IsNullOrWhiteSpace(SysReq.RAM))
                    {
                        MessageBox.Show("Obavezno je unijeti sve stavke za hardverske specifikacije!", "Upozorenje");
                    }
                    else
                    {
                        IgricaInsertRequest request = new IgricaInsertRequest()
                        {
                            SystemRequirements = SysReq,
                            Cijena = (float)nudCijena.Value,
                            DatumIzdavanja = dtpDatumIzdavanja.Value,
                            IzdavackaKucaId = int.Parse(cbIzdavackaKuca.SelectedValue.ToString()),
                            Naziv = txtNaziv.Text,
                            Opis = txtOpis.Text,
                    Tip = cbTip.SelectedItem as Tip,
                    Zanrovi = (List<Zanr>)clbZanr.CheckedItems.Cast<Models.Zanr>()
                        };
                        request.Slika = System.IO.File.ReadAllBytes(pbIgra.ImageLocation);
                        MessageBox.Show("Uspjesno ste dodali igricu", "Igrica");
                        var result = await _service.Insert<Models.Igrica>(request);
                    }
                }
                else
                {
                    MessageBox.Show("Obavezan odabir slike!", "Upozorenje");
                }
            }
        }

        private async void frmIgricaDodaj_Load(object sender, EventArgs e)
        {
            
            cbIzdavackaKuca.DataSource = await _izdavackaKuceService.GetAll<List<Models.IzdavackaKuca>>(null);
            cbIzdavackaKuca.DisplayMember = "Naziv";
            cbIzdavackaKuca.ValueMember = "Id";

            cbTip.DataSource = await _tipService.GetAll<List<Tip>>(null);
            cbTip.DisplayMember = "Naziv";
            cbTip.ValueMember = "Id";

            clbZanr.DataSource = await _zanrService.GetAll<List<Zanr>>(null);
            clbZanr.DisplayMember = "Naziv";

            if (_entity != null) 
            {
                pbIgra.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(Convert.ToBase64String(_entity.Slika))));
                SysReq.GrafickaKartica = _entity.SystemRequirements.GrafickaKartica;
                SysReq.Memorija = _entity.SystemRequirements.Memorija;
                SysReq.OperativniSistem = _entity.SystemRequirements.OperativniSistem;
                SysReq.Procesor = _entity.SystemRequirements.Procesor;
                SysReq.RAM = _entity.SystemRequirements.RAM;
                nudCijena.Value = (decimal)_entity.Cijena;
                dtpDatumIzdavanja.Value = _entity.DatumIzdavanja;
                cbIzdavackaKuca.SelectedValue = _entity.IzdavackaKuca.Id;
                txtNaziv.Text = _entity.Naziv;
                txtOpis.Text = _entity.Opis;
                cbTip.SelectedIndex = _entity.Tip.Id;
                foreach(Zanr zanr in _entity.Zanrovi)
                {
                    clbZanr.SetItemChecked(zanr.Id, true);
                }
            }

        }

        private void btnSysReq_Click(object sender, EventArgs e)
        {
            frmSysReqDodaj frm = new frmSysReqDodaj();
            frm.ShowDialog();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                epNaziv.SetError(txtNaziv, Properties.Resources.ObavezanUnosPolja);
            }
            else
            {
                epNaziv.Clear();
            }
        }

        //private void txtTip_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtTip.Text))
        //        epTip.SetError(txtTip, Properties.Resources.ObavezanUnosPolja);
        //    else
        //        epTip.Clear();
        //}

        private void dtpDatumIzdavanja_Validating(object sender, CancelEventArgs e)
        {
            
        }

        //private void txtZanr_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtZanr.Text))
        //        epZanr.SetError(txtZanr, Properties.Resources.ObavezanUnosPolja);
        //    else
        //        epZanr.Clear();
        //}

        private void nudCijena_Validating(object sender, CancelEventArgs e)
        {
            if (nudCijena.Value < 0)
                epCijena.SetError(nudCijena, Properties.Resources.ObavezanUnosPolja);
            else
                epCijena.Clear();
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
