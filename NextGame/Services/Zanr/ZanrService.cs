using AutoMapper;
using NextGame.Database;
using NextGame.Model.Requests.UlogaIZanr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public class ZanrService : BaseCRUDService<Model.Zanr, Database.Zanr, object, UlogaInsertRequest, UlogaUpdateRequest>, IZanrService
    {
        public ZanrService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
