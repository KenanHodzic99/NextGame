using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NextGame.Database;

namespace NextGame.Services
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> : ICRUDService<T, TSearch, TInsert, TUpdate> where T : class where TSearch : class where TInsert : class where TUpdate : class where TDb : class
    {
        public NextGameDBContext _dbContext { get; set; }
        protected readonly IMapper _mapper;

        public BaseCRUDService(NextGameDBContext dbContext, IMapper mapper) 
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public virtual IEnumerable<T> GetAll(TSearch search = null)
        {
            var entity = _dbContext.Set<TDb>();
            var list = entity.ToList();
            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = _dbContext.Set<TDb>();
            var entity = set.Find(id);
            return _mapper.Map<T>(entity);
        }
    

    public virtual T Insert(TInsert request)
        {
            var set = _dbContext.Set<TDb>();

            TDb entity = _mapper.Map<TDb>(request);

            set.Add(entity);
            _dbContext.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, TUpdate request)
        {
            var set = _dbContext.Set<TDb>();
            var entity = set.Find(id);

            _mapper.Map(request, entity);

            _dbContext.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Delete(int id)
        {
            var set = _dbContext.Set<TDb>();
            var entity = set.Find(id);

            if (entity != null)
            {
                set.Remove(entity);
            }

            _dbContext.SaveChanges();

            return null;
        }
    }
}
