using Microsoft.AspNetCore.Authorization;
using NextGame.Services;
using NextGame.Model.Requests.Korisnik;

namespace NextGame.Controllers
{
    [AllowAnonymous]
    public class KorisnikController : BaseCRUDController<Model.Korisnik,KorisnikSearchRequest,KorisnikInsertRequest,KorisnikUpdateRequest>
    {
        public KorisnikController(IKorisnikService service) : base(service)
        {

        }

    }
}
