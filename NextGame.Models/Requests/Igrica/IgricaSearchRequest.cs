namespace NextGame.Models.Requests.Igrica
{
    public class IgricaSearchRequest
    {
        
        public string Naziv { get; set; }
        public float? Ocjena { get; set; }
        public int? GodinaIzdavanja { get; set; }
        public string IzdavackaKuca { get; set; }
        public string Tip { get; set; }
        public string Zanr { get; set; }
        public string Platforma { get; set; }
        public float? Cijena { get; set; }
    }
}
