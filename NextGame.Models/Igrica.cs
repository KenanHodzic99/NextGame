using System;

namespace NextGame.Models
{
    public class Igrica
    {
        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string Naziv { get; set; }
        public float Ocjena { get; set; }
        public string Opis { get; set; }
        public SystemRequirements SystemRequirements { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public IzdavackaKuca IzdavackaKuca { get; set; }
        public string Tip { get; set; }
        public float Cijena { get; set; }
        public string Zanrovi { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
