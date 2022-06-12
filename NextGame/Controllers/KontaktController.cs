using NextGame.Model.Requests.Kontakt;
using NextGame.Services.Kontakt;

namespace NextGame.Controllers
{
    public class KontaktController : BaseCRUDController<Model.Kontakt, object, KontaktInsertRequest, KontaktUpdateRequest>
    {
        public KontaktController(IKontaktService service) : base(service)
        {
        }
    }
}
