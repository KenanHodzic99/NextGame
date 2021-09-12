using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Model
{
    public class KorisniciUloge
    {
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
