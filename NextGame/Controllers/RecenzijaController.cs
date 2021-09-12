using Microsoft.AspNetCore.Mvc;
using NextGame.Model;
using NextGame.Model.Requests.Recenzija;
using NextGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Controllers
{
    public class RecenzijaController : BaseCRUDController<Model.Recenzija, RecenzijaSearchRequest, RecenzijaInsertRequest, RecenzijaUpdateRequest>
    {
        public RecenzijaController(IRecenzijaService service) : base(service)
        {
        }
    }
}
