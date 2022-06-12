using NextGame.Model.Requests.ListaIgrica;
using NextGame.Services;

namespace NextGame.Controllers
{
    public class ListaIgricaController : BaseCRUDController<Model.ListaIgrica,ListaIgricaSearchRequest,ListaIgricaInsertRequest,ListaIgricaUpdateRequest>
    {
        public ListaIgricaController(IListaIgricaService service) :base(service)
        {

        }

    }
}
