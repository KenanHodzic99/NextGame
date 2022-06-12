using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Models
{
    public class Zanr
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public List<IgricaZanr> Igrice { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
