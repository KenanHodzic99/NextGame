namespace NextGame.Models
{
    public class SystemRequirements
    {
        public string OperativniSistem { get; set; }
        public string Procesor { get; set; }
        public string RAM { get; set; }
        public string GrafickaKartica { get; set; }
        public string Memorija { get; set; }

        public override string ToString()
        {
            return $"OS: {OperativniSistem}, CPU: {Procesor}, RAM: {RAM}, GPU: {GrafickaKartica}, Storage: {Memorija}";
        }
    }
}
