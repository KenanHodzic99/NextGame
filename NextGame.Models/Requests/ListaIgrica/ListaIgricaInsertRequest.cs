namespace NextGame.Models.Requests.ListaIgrica
{
    public class ListaIgricaInsertRequest
    {
        public int KorisnikId { get; set; }
        public int IgricaId { get; set; }
        public float Ocjena { get; set; }
        public int Sati { get; set; }
    }
}
