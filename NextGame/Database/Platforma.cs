using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NextGame.Database
{
    public class Platforma
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public ICollection<IgricaPlatforma> Igrice { get; set; }
    }
}
