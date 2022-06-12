using NextGame.Model.Requests.IzdavackaKuca;
using NextGame.Services;

namespace NextGame.Controllers
{
    public class IzdavackaKucaController : BaseCRUDController<Model.IzdavackaKuca,IzdavackaKucaSearchRequest,IzdavackaKucaInsertRequest,IzdavackaKucaUpdateRequest>
    {
        public IzdavackaKucaController(IIzdavackaKucaService service): base(service)
        {
            
        }
    }
}
