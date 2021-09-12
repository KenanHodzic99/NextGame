using System;
using System.Collections.Generic;

namespace NextGame.Models
{
    public class Korisnik
    {
        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string Username { get; set; }
        public DateTime DatumRođenja { get; set; }
        public string Opis { get; set; }
        public Kontakt Kontakt { get; set; }
        public Adresa Adresa { get; set; }
        public virtual ICollection<KorisniciUloge> Uloge { get; set; }
    }
}
