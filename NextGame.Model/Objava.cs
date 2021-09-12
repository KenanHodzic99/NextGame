﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NextGame.Model
{
    public class Objava
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public string Autor { get; set; }
        public DateTime DatumObjave { get; set; }
        public Igrica Igrica { get; set; }
    }
}
