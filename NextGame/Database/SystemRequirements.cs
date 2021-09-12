using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Database
{
    public class SystemRequirements
    {
        public int Id { get; set; }
        public string OperativniSistem { get; set; }
        public string Procesor { get; set; }
        public string RAM { get; set; }
        public string GrafickaKartica { get; set; }
        public string Memorija { get; set; }
        
    }
}
