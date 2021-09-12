using NextGame.Model.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public interface IKorisnikService : ICRUDService<Model.Korisnik, KorisnikSearchRequest, KorisnikInsertRequest, KorisnikUpdateRequest>
    {
        public Task<Model.Korisnik> Login(string username, string password);
    }
}
