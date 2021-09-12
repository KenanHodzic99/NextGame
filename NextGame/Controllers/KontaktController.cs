using Microsoft.AspNetCore.Mvc;
using NextGame.Model;
using NextGame.Model.Requests.Kontakt;
using NextGame.Services;
using NextGame.Services.Kontakt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Controllers
{
    public class KontaktController : BaseCRUDController<Model.Kontakt, object, KontaktInsertRequest, KontaktUpdateRequest>
    {
        public KontaktController(IKontaktService service) : base(service)
        {
        }
    }
}
