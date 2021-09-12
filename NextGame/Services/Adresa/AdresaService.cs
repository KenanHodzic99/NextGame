using AutoMapper;
using NextGame.Database;
using NextGame.Model.Requests.Adresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services.Adresa
{
    public class AdresaService : BaseCRUDService<Model.Adresa, Database.Adresa, object, AdresaInsertRequest, AdresaUpdateRequest>, IAdresaService
    {
        public AdresaService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
