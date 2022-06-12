using NextGame.Model.Requests.UlogaIZanr;
using NextGame.Services;

namespace NextGame.Controllers
{
    public class ZanrController : BaseCRUDController<Model.Zanr, object, UlogaInsertRequest, UlogaUpdateRequest>
    {
        public ZanrController(IZanrService service) : base(service)
        {
        }
    }
}
