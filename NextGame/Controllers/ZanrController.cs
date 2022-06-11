using Microsoft.AspNetCore.Mvc;
using NextGame.Model;
using NextGame.Model.Requests.UlogaIZanr;
using NextGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Controllers
{
    public class ZanrController : BaseCRUDController<Model.Zanr, object, UlogaInsertRequest, UlogaUpdateRequest>
    {
        public ZanrController(IZanrService service) : base(service)
        {
        }
    }
}
