using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        public IEnumerable<T> GetAll(TSearch search = null);
        public T GetById(int id);
        public T Insert(TInsert request);
        public T Update(int id, TUpdate request);
        public T Delete(int id);
    }

}
