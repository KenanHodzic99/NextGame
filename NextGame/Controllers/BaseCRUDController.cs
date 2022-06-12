using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NextGame.Services;
using System.Collections.Generic;

namespace NextGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : ControllerBase where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        protected readonly ICRUDService<T, TSearch, TInsert, TUpdate> _crudService;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service)
        {
            _crudService = service;
        }


        [HttpGet]
        public virtual IEnumerable<T> GetAll([FromQuery] TSearch search)
        {
            return _crudService.GetAll(search);
        }

        [HttpPost("{id}")]
        public virtual T GetById(int id)
        {
            return _crudService.GetById(id);
        }

        [HttpPost]
        public T Insert([FromBody] TInsert request)
        {
            return _crudService.Insert(request);
        }

        [HttpPut("{id}")]
        public T Update(int id, [FromBody] TUpdate request)
        {
            return _crudService.Update(id, request);
        }

        [HttpDelete("{id}")]
        public T Delete(int id)
        {
            return _crudService.Delete(id);
        }
    }
}
