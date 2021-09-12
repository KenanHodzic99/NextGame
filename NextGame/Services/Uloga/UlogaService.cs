using AutoMapper;
using NextGame.Database;
using NextGame.Model.Requests.UlogaIZanr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public class UlogaService : BaseCRUDService<Model.Uloga, Database.Uloga, object, UlogaInsertRequest, UlogaUpdateRequest>, IUlogaService
    {
        public UlogaService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
