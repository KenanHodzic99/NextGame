using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Model.Requests.Recenzija
{
    public class RecenzijaSearchRequest
    {
        public int igricaId { get; set; }
        public int korisnikId { get; set; }
    }
}