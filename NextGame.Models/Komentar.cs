using System;

namespace NextGame.Models
{
    public class Komentar
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public Objava Objava { get; set; }
        public int BrojLajkova { get; set; }
    }
}
