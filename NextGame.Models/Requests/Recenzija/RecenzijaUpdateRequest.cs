using System;

namespace NextGame.Models.Requests.Recenzija
{
    public class RecenzijaUpdateRequest
    {
        public bool? IsPrijavljena { get; set; }
        public float? Ocjena { get; set; }
        public DateTime? DatumPostavljanja { get; set; }
        public string? Sadrzaj { get; set; }
        public int? VrijemeIgranja { get; set; }
    }
}
