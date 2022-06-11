using AutoMapper;
using NextGame.Database;
using NextGame.Model.Requests.UlogaIZanr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public class TipService : BaseCRUDService<Model.Tip, Database.Tip, object, UlogaInsertRequest, UlogaUpdateRequest>, ITipService
    {
        public TipService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
