using AutoMapper;
using NextGame.Database;
using NextGame.Model.Requests.Kontakt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services.Kontakt
{
    public class KontaktService : BaseCRUDService<Model.Kontakt, Database.Kontakt, object, KontaktInsertRequest, KontaktUpdateRequest>, IKontaktService
    {
        public KontaktService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
