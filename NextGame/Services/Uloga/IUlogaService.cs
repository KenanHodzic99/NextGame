using NextGame.Model.Requests.UlogaIZanr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public interface IUlogaService : ICRUDService<Model.Uloga, object, UlogaInsertRequest, UlogaUpdateRequest>
    {
    }
}
