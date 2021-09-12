using NextGame.Model.Requests.Komentar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public interface IKomentarService : ICRUDService<Model.Komentar,KomentarSearchRequest,KomentarInsertRequest, KomentarUpdateRequest>
    {

    }
}
