using Microsoft.AspNetCore.Mvc;
using NextGame.Model;
using NextGame.Model.Requests.Adresa;
using NextGame.Services;
using NextGame.Services.Adresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Controllers
{
    public class AdresaController : BaseCRUDController<Model.Adresa, object, AdresaInsertRequest, AdresaUpdateRequest>
    {
        public AdresaController(IAdresaService service) : base(service)
        {
        }
    }
}
