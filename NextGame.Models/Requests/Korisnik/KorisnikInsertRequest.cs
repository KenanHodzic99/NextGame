using System;
using System.Collections.Generic;

namespace NextGame.Models.Requests.Korisnik
{
    public class KorisnikInsertRequest
    {
        public byte[] Slika { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DatumRođenja { get; set; }
        public Models.Adresa Adresa { get; set; }
        public Models.Kontakt Kontakt { get; set; }
        public string Opis { get; set; }
        public List<int> UlogeId { get; set; } = new List<int>();
    }
}
