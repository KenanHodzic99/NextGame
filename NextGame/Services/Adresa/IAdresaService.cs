using NextGame.Model.Requests.Adresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services.Adresa
{
    public interface IAdresaService : ICRUDService<Model.Adresa,object,AdresaInsertRequest,AdresaUpdateRequest>
    {
    }
}
