using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Database
{
    public class Korisnik
    {
        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DatumRođenja { get; set; }
        public int? KontaktId { get; set; }
        public Kontakt Kontakt { get; set; }
        public int? AdresaId { get; set; }
        public Adresa Adresa { get; set; }
        public string Opis { get; set; }
        public ICollection<KorisniciUloge> Uloge { get; set; }
    }
}
