using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Database
{
    public class Komentar
    {
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public int ObjavaId { get; set; }
        public Objava Objava { get; set; }
        public int BrojLajkova { get; set; }
    }
}
