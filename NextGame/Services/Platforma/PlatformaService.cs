using AutoMapper;
using NextGame.Database;
using NextGame.Model.Requests.UlogaIZanr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public class PlatformaService : BaseCRUDService<Model.Platforma, Database.Platforma, object, UlogaInsertRequest, UlogaUpdateRequest>, IPlatformaService
    {
        public PlatformaService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
