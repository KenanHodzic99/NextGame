using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Model
{
    public class Platforma
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public List<Igrica> Igrice { get; set; }
    }
}
