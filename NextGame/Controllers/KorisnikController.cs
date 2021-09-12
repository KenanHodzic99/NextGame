using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using NextGame.Model.Requests;
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
