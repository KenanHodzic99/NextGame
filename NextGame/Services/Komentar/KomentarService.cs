using AutoMapper;
using NextGame.Database;
using NextGame.Model.Requests.Komentar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NextGame.Services
{
    public class KomentarService : BaseCRUDService<Model.Komentar, Database.Komentar, KomentarSearchRequest, KomentarInsertRequest, KomentarUpdateRequest>, IKomentarService
    {
        public KomentarService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }


        public override IEnumerable<Model.Komentar> GetAll(KomentarSearchRequest request = null)
        {
            var entity = _dbContext.Set<Database.Komentar>().Include(x => x.Korisnik).Include(x=>x.Objava);

            if (request != null)
            {
                var list = entity.Where(x => x.ObjavaId == request.ObjavaId).ToList();
                return _mapper.Map<List<Model.Komentar>>(list).OrderByDescending(x=>x.BrojLajkova);
            }
            else
            {
                var list = entity.ToList();
                return _mapper.Map<List<Model.Komentar>>(list).OrderByDescending(x => x.BrojLajkova);
            }
        }

        public override Model.Komentar Insert(KomentarInsertRequest request)
        {
            var set = _dbContext.Set<Komentar>();

            var entity = _mapper.Map<Komentar>(request);

            entity.KorisnikId = request.KorisnikId;
            entity.Korisnik = _dbContext.Korisnici.Find(request.KorisnikId);

            entity.ObjavaId = request.ObjavaId;
            entity.Objava = _dbContext.Objave.Find(request.ObjavaId);

            set.Add(entity);
            _dbContext.SaveChanges();

            return _mapper.Map<Model.Komentar>(entity);
        }

    }
}
