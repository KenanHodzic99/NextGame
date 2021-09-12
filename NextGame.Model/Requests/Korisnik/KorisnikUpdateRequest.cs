using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Model.Requests.Korisnik
{
    public class KorisnikUpdateRequest
    {
        public byte[] Slika { get; set; }
        public string Password { get; set; }
        public DateTime DatumRođenja { get; set; }
        public Model.Adresa Adresa { get; set; }
        public Model.Kontakt Kontakt { get; set; }
        public string Opis { get; set; }
        public List<int> UlogeId { get; set; } = new List<int>();
    }
}
