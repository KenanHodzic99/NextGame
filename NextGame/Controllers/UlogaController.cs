using NextGame.Model.Requests.UlogaIZanr;
using NextGame.Services;

namespace NextGame.Controllers
{
    public class UlogaController : BaseCRUDController<Model.Uloga, object, UlogaInsertRequest, UlogaUpdateRequest>
    {
        public UlogaController(IUlogaService service) : base(service)
        {
        }
    }
}
