﻿using System;

namespace NextGame.Models
{
    public class Recenzija
    {
        public int Id { get; set; }      
        public Korisnik Korisnik { get; set; }
        public Igrica Igrica { get; set; }
        public bool IsPrijavljena { get; set; }
        public float Ocjena { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public string Sadrzaj { get; set; }
        public int VrijemeIgranja { get; set; }
    }
}
