using NextGame.Model.Requests.Igrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public interface IIgricaService : ICRUDService<Model.Igrica, IgricaSearchRequest, IgricaInsertRequest,IgricaUpdateRequest>
    {
        public List<Model.Igrica> Recomend(int id);
    }
}
