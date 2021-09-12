using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Model.Requests.Adresa
{
    public class AdresaInsertRequest
    {
        public string Kontinent { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string PostanskiBroj { get; set; }
    }
}
