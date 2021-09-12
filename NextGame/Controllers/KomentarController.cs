using Microsoft.AspNetCore.Mvc;
using NextGame.Model;
using NextGame.Model.Requests.Komentar;
using NextGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Controllers
{
    public class KomentarController : BaseCRUDController<Model.Komentar, KomentarSearchRequest, KomentarInsertRequest, KomentarUpdateRequest>
    {
        public KomentarController(IKomentarService service) : base(service)
        {
        }
    }
}
