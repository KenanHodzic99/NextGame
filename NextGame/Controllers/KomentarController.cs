using NextGame.Model.Requests.Komentar;
using NextGame.Services;

namespace NextGame.Controllers
{
    public class KomentarController : BaseCRUDController<Model.Komentar, KomentarSearchRequest, KomentarInsertRequest, KomentarUpdateRequest>
    {
        public KomentarController(IKomentarService service) : base(service)
        {
        }
    }
}
