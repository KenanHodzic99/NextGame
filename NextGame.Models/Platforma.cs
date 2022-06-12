using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Models
{
    public class Platforma
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public List<IgricaPlatforma> Igrice { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
