using System;

namespace NextGame.Models.Requests.IzdavackaKuca
{
    public class IzdavackaKucaInsertRequest
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
