using Microsoft.AspNetCore.Mvc;
using NextGame.Model;
using NextGame.Model.Requests.SystemRequirements;
using NextGame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Controllers
{
    public class SystemRequirementsController : BaseCRUDController<Model.SystemRequirements, object, SystemRequirementsInsertRequest, SystemRequirementsUpdateRequest>
    {
        public SystemRequirementsController(ISystemRequirementsService service) : base(service)
        {
        }
    }
}
