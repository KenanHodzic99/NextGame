using NextGame.Model.Requests.Objava;
using NextGame.Services;

namespace NextGame.Controllers
{
    public class ObjavaController : BaseCRUDController<Model.Objava, ObjavaSearchRequest, ObjavaInsertRequest, ObjavaUpdateRequest>
    {
        public ObjavaController(IObjavaService service) : base(service)
        {
        }
    }
}
