using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NextGame.Database
{
    public class Zanr
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public ICollection<IgricaZanr> Igrice { get; set; }
    }
}