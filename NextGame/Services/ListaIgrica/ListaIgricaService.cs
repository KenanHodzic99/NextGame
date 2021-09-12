using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NextGame.Database;
using NextGame.Model.Requests.ListaIgrica;

namespace NextGame.Services.ListaIgrica
{
    public class ListaIgricaServis : BaseCRUDService<Model.ListaIgrica,Database.ListaIgrica,ListaIgricaSearchRequest,ListaIgricaInsertRequest,ListaIgricaUpdateRequest> , IListaIgricaService
    {
        public ListaIgricaServis(NextGameDBContext dBContext, IMapper mapper):base(dBContext, mapper)
        {
            
        }

        public override IEnumerable<Model.ListaIgrica> GetAll(ListaIgricaSearchRequest search = null)
        {
            var entity = _dbContext.Set<Database.ListaIgrica>().Include(x => x.Korisnik).Include(x => x.Igrica).AsQueryable();

            if (search != null)
            {
                entity.Where(x => x.KorisnikId == search.KorisnikId);
            }


            var list = entity.ToList();

            return _mapper.Map<List<Model.ListaIgrica>>(list);
        }

        public override Model.ListaIgrica Insert(ListaIgricaInsertRequest request)
        {
            var setLista = _dbContext.Set<Database.ListaIgrica>();

            Database.ListaIgrica entity = _mapper.Map<Database.ListaIgrica>(request);

            setLista.Add(entity);

            entity.Igrica = _dbContext.Igrice.Find(request.IgricaId);
            entity.Korisnik = _dbContext.Korisnici.Find(request.KorisnikId);

            _dbContext.SaveChanges();

            return _mapper.Map<Model.ListaIgrica>(entity);
        }

        public override Model.ListaIgrica Update(int id, ListaIgricaUpdateRequest request)
        {
            Database.ListaIgrica entity = _dbContext.ListaIgrica.Find(id);

            if (request.Ocjena != null)
            {
                entity.Ocjena = (float) request.Ocjena;
            }

            if (request.Sati != null)
            {
                entity.Sati = (int) request.Sati;
            }


            _dbContext.SaveChanges();
            return _mapper.Map<Model.ListaIgrica>(entity);
        }
    }
}
