using NextGame.Model.Requests.Recenzija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public interface IRecenzijaService : ICRUDService<Model.Recenzija,RecenzijaSearchRequest,RecenzijaInsertRequest,RecenzijaUpdateRequest>
    {
    }
}
