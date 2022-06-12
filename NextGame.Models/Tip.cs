using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Models
{
    public class Tip
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public List<Igrica> Igrice { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
