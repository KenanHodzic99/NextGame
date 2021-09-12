using AutoMapper;
using NextGame.Database;
using NextGame.Model.Requests.IzdavackaKuca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public class IzdavackaKucaService : BaseCRUDService<Model.IzdavackaKuca, IzdavackaKuca, IzdavackaKucaSearchRequest, IzdavackaKucaInsertRequest,IzdavackaKucaUpdateRequest> , IIzdavackaKucaService
    {
        public IzdavackaKucaService(NextGameDBContext dBContext, IMapper mapper) :base(dBContext, mapper)
        {
           
        }

        public override IEnumerable<Model.IzdavackaKuca> GetAll(IzdavackaKucaSearchRequest search = null)
        {
            var entity = _dbContext.Set<IzdavackaKuca>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }

            if (!string.IsNullOrWhiteSpace(search?.MjestoOsnivanja))
            {
                entity = entity.Where(x => x.MjestoOsnivanja.Contains(search.MjestoOsnivanja));
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.IzdavackaKuca>>(list);
        }
    }
}
