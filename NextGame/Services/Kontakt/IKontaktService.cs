using NextGame.Model.Requests.Kontakt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services.Kontakt
{
    public interface IKontaktService : ICRUDService<Model.Kontakt,object,KontaktInsertRequest,KontaktUpdateRequest>
    {
    }
}
