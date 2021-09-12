namespace NextGame.Models
{
    public class ListaIgrica
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public Igrica Igrica { get; set; }
        public float Ocjena { get; set; }
        public int Sati { get; set; }
    }
}
