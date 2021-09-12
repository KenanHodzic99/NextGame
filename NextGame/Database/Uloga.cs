using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Database
{
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
