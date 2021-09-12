using Microsoft.AspNetCore.Mvc;
using NextGame.Model.Requests.ListaIgrica;
using NextGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NextGame.Model;

namespace NextGame.Controllers
{
    public class ListaIgricaController : BaseCRUDController<Model.ListaIgrica,ListaIgricaSearchRequest,ListaIgricaInsertRequest,ListaIgricaUpdateRequest>
    {
        public ListaIgricaController(IListaIgricaService service) :base(service)
        {

        }

    }
}
