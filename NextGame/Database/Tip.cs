using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NextGame.Database
{
    public class Tip
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        [JsonIgnore]
        public ICollection<Igrica> Igrice { get; set; }
    }
}
