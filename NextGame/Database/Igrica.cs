using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Database
{
    public class Igrica
    {
        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string Naziv { get; set; }
        public float? Ocjena { get; set; }
        public string Opis { get; set; }
        public int SystemRequirementsId { get; set; }
        public SystemRequirements SystemRequirements { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int IzdavackaKucaId { get; set; }
        public IzdavackaKuca IzdavackaKuca { get; set; }
        public string Tip { get; set; }
        public float Cijena { get; set; }
        public string Zanrovi { get; set; }
    }
}
