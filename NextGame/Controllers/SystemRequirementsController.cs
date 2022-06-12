using NextGame.Model.Requests.SystemRequirements;
using NextGame.Services;

namespace NextGame.Controllers
{
    public class SystemRequirementsController : BaseCRUDController<Model.SystemRequirements, object, SystemRequirementsInsertRequest, SystemRequirementsUpdateRequest>
    {
        public SystemRequirementsController(ISystemRequirementsService service) : base(service)
        {
        }
    }
}
