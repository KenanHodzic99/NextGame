using NextGame.Model.Requests.UlogaIZanr;
using NextGame.Services;

namespace NextGame.Controllers
{
    public class TipController : BaseCRUDController<Model.Tip, object, UlogaInsertRequest, UlogaUpdateRequest>
    {
        public TipController(ITipService service) : base(service)
        {
        }
    }
}
