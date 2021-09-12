using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Database
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
