using Microsoft.AspNetCore.Mvc;
using NextGame.Model;
using NextGame.Model.Requests.Objava;
using NextGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Controllers
{
    public class ObjavaController : BaseCRUDController<Model.Objava, ObjavaSearchRequest, ObjavaInsertRequest, ObjavaUpdateRequest>
    {
        public ObjavaController(IObjavaService service) : base(service)
        {
        }
    }
}
