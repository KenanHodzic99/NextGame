using System;

namespace NextGame.Models.Requests.Objava
{
    public class ObjavaInsertRequest
    {
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public string Autor { get; set; }
        public DateTime DatumObjave { get; set; }
        public int IgricaId { get; set; }
    }
}
