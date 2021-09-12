using NextGame.Model.Requests.Objava;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public interface IObjavaService : ICRUDService<Model.Objava,ObjavaSearchRequest,ObjavaInsertRequest,ObjavaUpdateRequest>
    {
    }
}
