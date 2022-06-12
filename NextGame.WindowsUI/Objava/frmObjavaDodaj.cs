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
    public partial class frmObjavaDodaj : Form
    {
        private APIService _service = new APIService("Objava");
        private APIService _IgraService = new APIService("Igrica");
        private Models.Objava _entity;
        public frmObjavaDodaj(Models.Objava entity = null)
        {
            InitializeComponent();
            _entity = entity;
        }

        private async void frmObjavaDodaj_Load(object sender, EventArgs e)
        {
            cbIgrica.DataSource = await _IgraService.GetAll<List<Models.Igrica>>(null);
            cbIgrica.DisplayMember = "Naziv";
            cbIgrica.ValueMember = "Id";

            if (_entity != null)
            {
                txtOpis.Text = _entity.Sadrzaj;
                txtAutor.Text = _entity.Autor;
                txtNaslov.Text = _entity.Naslov;
                cbIgrica.SelectedValue = _entity.Igrica.Id;
                cbIgrica.Enabled = false;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text) || txtNaslov.Text.Length < 5 || string.IsNullOrWhiteSpace(txtAutor.Text) || txtNaslov.Text.Length < 5 || string.IsNullOrWhiteSpace(txtOpis.Text) || txtOpis.Text.Length < 10)
            {
                MessageBox.Show("Molimo provjerite da li ste korektno unijeli sve podatke!", "Objava");
                this.Validate();
                return;
            }

            if (_entity != null)
            {
                ObjavaUpdateRequest request = new ObjavaUpdateRequest() 
                {
                    Sadrzaj = txtOpis.Text,
                    Autor = txtAutor.Text,
                    DatumObjave = DateTime.Today,
                    Naslov = txtNaslov.Text,
                };
                var result = await _service.Update<Models.Objava>(_entity.Id, request);
                if(MessageBox.Show("Uspjesno ste ažurirali objavu!", "Objava") == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                ObjavaInsertRequest request = new ObjavaInsertRequest()
                {
                    Sadrzaj = txtOpis.Text,
                    Autor = txtAutor.Text,
                    DatumObjave = DateTime.Today,
                    Naslov = txtNaslov.Text,
                    IgricaId = int.Parse(cbIgrica.SelectedValue.ToString())
                };
                MessageBox.Show("Uspjesno ste dodali objavu!", "Objava");
                var result = await _service.Insert<Models.Objava>(request);
            }
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text))
                epNaslov.SetError(txtNaslov, Properties.Resources.ObavezanUnosPolja + " Minimalno 5 karaktera!");
            else
                epNaslov.Clear();
        }

        private void txtAutor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
                epAutor.SetError(txtAutor, Properties.Resources.ObavezanUnosPolja + " Minimalno 5 karaktera!");
            else
                epAutor.Clear();
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
                epSadrzaj.SetError(txtOpis, Properties.Resources.ObavezanUnosPolja + " Minimalno 10 karaktera!");
            else
                epSadrzaj.Clear();
        }
    }
}
