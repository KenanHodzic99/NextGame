using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Model.Requests.IzdavackaKuca
{
    public class IzdavackaKucaUpdateRequest
    {
        public byte[] Slika { get; set; }
        public string Naziv { get; set; }
        public int BrojZaposlenika { get; set; }
        public DateTime DatumOsnivanja { get; set; }
        public string Osnivaci { get; set; }
        public string MjestoOsnivanja { get; set; }
        public string Sjediste { get; set; }
        public string Opis { get; set; }
    }
}
