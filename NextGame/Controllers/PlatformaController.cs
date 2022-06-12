using NextGame.Model.Requests.UlogaIZanr;
using NextGame.Services;

namespace NextGame.Controllers
{
    public class PlatformaController : BaseCRUDController<Model.Platforma, object, UlogaInsertRequest, UlogaUpdateRequest>
    {
        public PlatformaController(IPlatformaService service) : base(service)
        {
        }
    }
}
