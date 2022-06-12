using System;
using System.Collections.Generic;

namespace NextGame.Models.Requests.Igrica
{
    public class IgricaUpdateRequest
    {
        public byte[] Slika { get; set; }
        public string Naziv { get; set; }
        public float Ocjena { get; set; }
        public string Opis { get; set; }
        public Models.SystemRequirements SystemRequirements { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int IzdavackaKucaId { get; set; }
        public Tip Tip { get; set; }
        public float Cijena { get; set; }
        public List<int> ZanroviId { get; set; } = new List<int>();
        public List<int> PlatformeId { get; set; } = new List<int>();

    }
}
