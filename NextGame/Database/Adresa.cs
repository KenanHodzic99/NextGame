using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Database
{
    public class Adresa
    {
        public int Id { get; set; }
        public string Kontinent { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string PostanskiBroj { get; set; }
    }
}
