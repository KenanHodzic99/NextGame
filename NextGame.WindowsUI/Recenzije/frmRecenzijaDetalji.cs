using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextGame.WindowsUI.Recenzije
{
    public partial class frmRecenzijaDetalji : Form
    {
        private Models.Recenzija _recenzija;
        private APIService _service = new APIService("Recenzija");
        public frmRecenzijaDetalji(Models.Recenzija recenzija)
        {
            _recenzija = recenzija;
            InitializeComponent();
        }

        private void frmRecenzijaDetalji_Load(object sender, EventArgs e)
        {
            txtAutor.Text = _recenzija.Korisnik.Username;
            txtAutor.ReadOnly = true;

            txtIgrica.Text = _recenzija.Igrica.Naziv;
            txtIgrica.ReadOnly = true;

            txtOcjena.Text = _recenzija.Ocjena.ToString() + "/5";
            txtOcjena.ReadOnly = true;

            txtOpis.Text = _recenzija.Sadrzaj;
            txtOpis.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var temp = _service.Delete<Models.Recenzija>(_recenzija.Id);
            if (temp != null)
            {
                MessageBox.Show("Uspješno ste uklonili recenziju!","Objavještenje");
                this.Close();
            }
        }
    }
}
