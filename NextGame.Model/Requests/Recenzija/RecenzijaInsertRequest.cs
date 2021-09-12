using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Model.Requests.Recenzija
{
    public class RecenzijaInsertRequest
    {
        public int KorisnikId { get; set; }
        public int IgricaId { get; set; }
        public bool IsPrijavljena { get; set; }
        public float Ocjena { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public string Sadrzaj { get; set; }
        public int VrijemeIgranja { get; set; }
    }
}
