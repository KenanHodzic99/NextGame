using System;

namespace NextGame.Models
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
