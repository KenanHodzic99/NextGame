using NextGame.Model.Requests.ListaIgrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public interface IListaIgricaService : ICRUDService<Model.ListaIgrica,ListaIgricaSearchRequest,ListaIgricaInsertRequest,ListaIgricaUpdateRequest>
    {
    }
}
