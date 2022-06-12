using NextGame.Model.Requests.Recenzija;
using NextGame.Services;

namespace NextGame.Controllers
{
    public class RecenzijaController : BaseCRUDController<Model.Recenzija, RecenzijaSearchRequest, RecenzijaInsertRequest, RecenzijaUpdateRequest>
    {
        public RecenzijaController(IRecenzijaService service) : base(service)
        {
        }
    }
}
