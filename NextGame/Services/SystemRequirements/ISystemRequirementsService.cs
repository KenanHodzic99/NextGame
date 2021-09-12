using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NextGame.Model.Requests.SystemRequirements;

namespace NextGame.Services
{
    public interface ISystemRequirementsService : ICRUDService<Model.SystemRequirements,object,SystemRequirementsInsertRequest, SystemRequirementsUpdateRequest>
    {
    }
}
