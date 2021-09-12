using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Services
{
    public interface IIzdavackaKucaService : ICRUDService<Model.IzdavackaKuca,Model.Requests.IzdavackaKuca.IzdavackaKucaSearchRequest, Model.Requests.IzdavackaKuca.IzdavackaKucaInsertRequest, Model.Requests.IzdavackaKuca.IzdavackaKucaUpdateRequest>
    {

    }
}
