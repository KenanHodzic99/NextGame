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
    public class UlogaController : BaseCRUDController<Model.Uloga, object, UlogaInsertRequest, UlogaUpdateRequest>
    {
        public UlogaController(IUlogaService service) : base(service)
        {
        }
    }
}
