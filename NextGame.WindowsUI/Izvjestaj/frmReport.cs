using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace NextGame.WindowsUI.Izvjestaj
{
    public partial class frmReport : Form
    {
        private APIService _service = new APIService("Igrica");
        private APIService _izdavackaKuceService = new APIService("IzdavackaKuca");
        private APIService _korisniciService = new APIService("Korisnik");
        private APIService _listaIgrica = new APIService("ListaIgrica");

        public frmReport()
        {
            InitializeComponent();
        }

        private async void frmReport_LoadAsync(object sender, EventArgs e)
        {
            int ukupniSatiIgranja = 0;
            int brojKorisnika = 0;
            Models.Igrica najboljaIgrica = new Models.Igrica();
            float ocjena = float.MinValue;

            var igrice = await _service.GetAll<List<Models.Igrica>>(null);

            foreach (var igrica in igrice)
            {
                if(igrica.Ocjena > ocjena)
                {
                    ocjena = igrica.Ocjena;
                    najboljaIgrica = igrica;
                }
            }

            var ListaIgrica = await _listaIgrica.GetAll<List<Models.ListaIgrica>>(null);

            foreach (var lista in ListaIgrica)
            {
                if(lista.Igrica.Id == najboljaIgrica.Id)
                {
                    ukupniSatiIgranja += lista.Sati;
                    brojKorisnika++;
                }
            }

            Microsoft.Reporting.WinForms.ReportParameterCollection rpc = new ReportParameterCollection();

            rpc.Add(new ReportParameter("NazivIgrice", najboljaIgrica.Naziv));
            rpc.Add(new ReportParameter("SatiIgrice", ukupniSatiIgranja.ToString()));
            rpc.Add(new ReportParameter("OpisIgrice", najboljaIgrica.Opis));
            rpc.Add(new ReportParameter("IzdavackaKuca" , najboljaIgrica.IzdavackaKuca.Naziv));
            rpc.Add(new ReportParameter("DatumIzlaska", najboljaIgrica.DatumIzdavanja.ToShortDateString()));
            rpc.Add(new ReportParameter("DatumReporta", DateTime.Now.ToShortDateString()));
            rpc.Add(new ReportParameter("OcjenaIgre", najboljaIgrica.Ocjena.ToString()));
            rpc.Add(new ReportParameter("BrojKorisnikaKojiSuIgrali", brojKorisnika.ToString()));

            reportViewer1.LocalReport.SetParameters(rpc);

            this.reportViewer1.RefreshReport();
        }
    }
}
