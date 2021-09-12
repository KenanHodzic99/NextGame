using System;

namespace NextGame.Models.Requests.Komentar
{
    public class KomentarUpdateRequest
    {
        public string Sadrzaj { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public int BrojLajkova { get; set; }
    }
}
