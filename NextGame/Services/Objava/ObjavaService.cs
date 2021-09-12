using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NextGame.Database;
using NextGame.Model.Requests.Objava;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public class ObjavaService : BaseCRUDService<Model.Objava, Database.Objava, ObjavaSearchRequest, ObjavaInsertRequest, ObjavaUpdateRequest>, IObjavaService
    {
        public ObjavaService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override IEnumerable<Model.Objava> GetAll(ObjavaSearchRequest search = null)
        {
            var entity = _dbContext.Set<Objava>().Include(x=>x.Igrica).Include(x=>x.Igrica.SystemRequirements).Include(x=>x.Igrica.IzdavackaKuca).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naslov))
            {
                entity = entity.Where(x => x.Naslov.Contains(search.Naslov));
            }

            if (!string.IsNullOrWhiteSpace(search?.Igrica))
            {
                entity = entity.Where(x => x.Igrica.Naziv.Contains(search.Igrica));
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Objava>>(list);
        }

        public override Model.Objava Insert(ObjavaInsertRequest request)
        {
            var set = _dbContext.Set<Objava>();

            var entity = _mapper.Map<Objava>(request);

            entity.IgricaId = request.IgricaId;
            entity.Igrica = _dbContext.Igrice.Find(request.IgricaId);

            set.Add(entity);

            _dbContext.SaveChanges();

            return _mapper.Map<Model.Objava>(entity);
        }
    }
}
