using NextGame.Model.Requests.Adresa;
using NextGame.Services.Adresa;

namespace NextGame.Controllers
{
    public class AdresaController : BaseCRUDController<Model.Adresa, object, AdresaInsertRequest, AdresaUpdateRequest>
    {
        public AdresaController(IAdresaService service) : base(service)
        {
        }
    }
}
