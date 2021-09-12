using System;

namespace NextGame.Models.Requests.Komentar
{
    public class KomentarInsertRequest
    {
        public int KorisnikId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public int ObjavaId { get; set; }
        public int BrojLajkova { get; set; }
    }
}
