using AutoMapper;
using NextGame.Database;
using NextGame.Model.Requests.SystemRequirements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public class SystemRequirementsService : BaseCRUDService<Model.SystemRequirements, Database.SystemRequirements, object, SystemRequirementsInsertRequest, SystemRequirementsUpdateRequest>, ISystemRequirementsService
    {
        public SystemRequirementsService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
