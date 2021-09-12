using AutoMapper;
using NextGame.Database;
using NextGame.Model.Requests.Recenzija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NextGame.Services
{
    public class RecenzijaService : BaseCRUDService<Model.Recenzija, Database.Recenzija, RecenzijaSearchRequest, RecenzijaInsertRequest, RecenzijaUpdateRequest>, IRecenzijaService
    {
        public RecenzijaService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override IEnumerable<Model.Recenzija> GetAll(RecenzijaSearchRequest search = null)
        {
            var entity = _dbContext.Recenzije.Include(x=>x.Igrica).Include(x=>x.Korisnik);

            if (search != null)
            {
                if (search.igricaId != 0)
                {
                    var list = entity.Where(x => x.Igrica.Id == search.igricaId).ToList();
                    return _mapper.Map<List<Model.Recenzija>>(list).OrderByDescending(x => x.Ocjena);
                }
                if(search.korisnikId != 0)
                {
                    var list = entity.Where(x => x.Korisnik.Id == search.korisnikId).ToList();
                    return _mapper.Map<List<Model.Recenzija>>(list).OrderByDescending(x => x.Ocjena);
                }
            }

            var lista = entity.ToList();
            return _mapper.Map<List<Model.Recenzija>>(lista).OrderByDescending(x => x.Ocjena);
        }

        public override Model.Recenzija Update(int id, RecenzijaUpdateRequest request)
        {
            var entity = _dbContext.Recenzije.Find(id);

            if (request.DatumPostavljanja != null)
            {
                entity.DatumPostavljanja = (DateTime)request.DatumPostavljanja;
            }

            if (request.Ocjena != null)
            {
                entity.Ocjena = (float)request.Ocjena;
            }

            if (request.IsPrijavljena != null)
            {
                entity.IsPrijavljena = (bool)request.IsPrijavljena;
            }

            if (request.Sadrzaj != null)
            {
                entity.Sadrzaj = request.Sadrzaj;
            }

            if (request.VrijemeIgranja != null)
            {
                entity.VrijemeIgranja = (int)request.VrijemeIgranja;
            }

            _dbContext.SaveChanges();
            return _mapper.Map<Model.Recenzija>(entity);
        }

        public override Model.Recenzija Insert(RecenzijaInsertRequest request)
        {
            var set = _dbContext.Set<Recenzija>();
            var entity = _mapper.Map<Recenzija>(request);

            var igricaEntity = _dbContext.Igrice.Find(request.IgricaId);
            entity.IgricaId = request.IgricaId;
            entity.Igrica = igricaEntity;

            entity.KorisnikId = request.KorisnikId;
            entity.Korisnik = _dbContext.Korisnici.Find(request.KorisnikId);

            set.Add(entity);

            _dbContext.SaveChanges();

            var recenzije = _dbContext.Recenzije.Select(x => x.Ocjena).ToList();

            igricaEntity.Ocjena = 0;

            foreach (var recenzija in recenzije)
            {
                igricaEntity.Ocjena += recenzija;
            }

            entity.Igrica.Ocjena /= recenzije.Count;
            

            _dbContext.SaveChanges();

            return _mapper.Map<Model.Recenzija>(entity);
        }
    }
}
