using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Model
{
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
