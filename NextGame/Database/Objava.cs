using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Database
{
    public class Objava
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public string Autor { get; set; }
        public DateTime DatumObjave { get; set; }
        public int IgricaId { get; set; }
        public Igrica Igrica { get; set; }
     
    }
}
