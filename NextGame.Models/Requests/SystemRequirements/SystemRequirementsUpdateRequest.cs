namespace NextGame.Models.Requests.SystemRequirements
{
    public class SystemRequirementsUpdateRequest
    {
        public string OperativniSistem { get; set; }
        public string Procesor { get; set; }
        public string RAM { get; set; }
        public string GrafickaKartica { get; set; }
        public string Memorija { get; set; }
    }
}
