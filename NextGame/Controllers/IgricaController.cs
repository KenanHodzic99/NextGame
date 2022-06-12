using Microsoft.AspNetCore.Mvc;
using NextGame.Model.Requests.Igrica;
using NextGame.Services;
using System.Collections.Generic;

namespace NextGame.Controllers
{
    public class IgricaController : BaseCRUDController<Model.Igrica, IgricaSearchRequest, IgricaInsertRequest, IgricaUpdateRequest>
    {
        public IgricaController(IIgricaService service) : base(service)
        {
        }

        [HttpGet("Recommend/{id}")]
        public List<Model.Igrica> Recomend(int id)
        {
            return (_crudService as IIgricaService).Recomend(id);
        }
    }
}
