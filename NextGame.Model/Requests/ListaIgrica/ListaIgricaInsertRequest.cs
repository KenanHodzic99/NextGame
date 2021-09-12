using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace NextGame.Model.Requests.ListaIgrica
{
    public class ListaIgricaInsertRequest
    {
        public int KorisnikId { get; set; }
        public int IgricaId { get; set; }
        public float Ocjena { get; set; }
        public int Sati { get; set; }
    }
}
