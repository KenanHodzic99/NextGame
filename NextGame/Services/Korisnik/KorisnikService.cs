using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NextGame.Database;
using NextGame.Filters;
using NextGame.Model.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace NextGame.Services
{
    public class KorisnikService : BaseCRUDService<Model.Korisnik,Database.Korisnik,Model.Requests.Korisnik.KorisnikSearchRequest, Model.Requests.Korisnik.KorisnikInsertRequest, Model.Requests.Korisnik.KorisnikUpdateRequest>, IKorisnikService
    {
        public KorisnikService(NextGameDBContext service, IMapper mapper) : base(service, mapper)
        {

        }

        public override IEnumerable<Model.Korisnik> GetAll(KorisnikSearchRequest search = null)
        {
            var entity = _dbContext.Set<Korisnik>().Include(x=>x.Adresa).Include(x=>x.Kontakt).Include(x=>x.Uloge).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                entity = entity.Where(x => x.Username.Contains(search.Username));
            }


            var list = entity.ToList();

            return _mapper.Map<List<Model.Korisnik>>(list);
        }

       [AllowAnonymous]
        public override Model.Korisnik Insert(KorisnikInsertRequest request)
        {
            var setKorisnici = _dbContext.Set<Korisnik>();

            Korisnik entity = _mapper.Map<Korisnik>(request);
            setKorisnici.Add(entity);

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt,request.Password);

            _dbContext.SaveChanges();

            if (request.UlogeId.Count>0)
            {
                foreach (var id in request.UlogeId)
                {
                    Database.KorisniciUloge korisniciUloge = new KorisniciUloge();
                    korisniciUloge.KorisnikId = entity.Id;
                    korisniciUloge.UlogaId = id;
                    korisniciUloge.DatumIzmjene = DateTime.Now;

                    _dbContext.KorisniciUloge.Add(korisniciUloge);
                }
            }
            else
            {
                Database.KorisniciUloge korisniciUloge = new KorisniciUloge();
                korisniciUloge.KorisnikId = entity.Id;
                korisniciUloge.UlogaId = 1;
                korisniciUloge.DatumIzmjene = DateTime.Now;

                _dbContext.KorisniciUloge.Add(korisniciUloge);
            }

            if(request.Kontakt != null)
            {
                var setKontakt = _dbContext.Set<Database.Kontakt>();

                var Kontaktentity = _mapper.Map<Database.Kontakt>(request.Kontakt);

                setKontakt.Add(Kontaktentity);

                entity.KontaktId = Kontaktentity.Id;
                entity.Kontakt = Kontaktentity;
            }

            if (request.Adresa != null)
            {
                var setAdresa = _dbContext.Set<Database.Adresa>();

                var AdresaEntity = _mapper.Map<Database.Adresa>(request.Adresa);

                setAdresa.Add(AdresaEntity);

                entity.AdresaId = AdresaEntity.Id;
                entity.Adresa = AdresaEntity;
            }

            _dbContext.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }

        public override Model.Korisnik Update(int id, KorisnikUpdateRequest request)
        {
            var entity = _dbContext.Korisnici.Find(id);

            _mapper.Map(request, entity);


            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }
            if (request.UlogeId.Count > 0)
            {
                foreach (var ulogaid in request.UlogeId)
                {
                    Database.KorisniciUloge korisniciUloge = new KorisniciUloge();
                    korisniciUloge.KorisnikId = entity.Id;
                    korisniciUloge.UlogaId = ulogaid;
                    korisniciUloge.DatumIzmjene = DateTime.Now;

                    _dbContext.KorisniciUloge.Add(korisniciUloge);
                }
            }
            if (request.Kontakt != null)
            {
                if (entity.Kontakt == null)
                {
                    var setKontakt = _dbContext.Set<Database.Kontakt>();
                    var Kontaktentity = _mapper.Map<Database.Kontakt>(request.Kontakt);

                    setKontakt.Add(Kontaktentity);

                    entity.KontaktId = Kontaktentity.Id;
                    entity.Kontakt = Kontaktentity;
                }
                else
                {
                    var Kontaktentity = _dbContext.Kontakti.Find(entity.KontaktId);
                    Kontaktentity = _mapper.Map<Database.Kontakt>(request.Kontakt);
                }
            }

            if (request.Adresa != null)
            {
                if (entity.Kontakt == null)
                {
                    var setAdresa = _dbContext.Set<Database.Adresa>();
                    var AdresaEntity = _mapper.Map<Database.Adresa>(request.Adresa);

                    setAdresa.Add(AdresaEntity);

                    entity.AdresaId = AdresaEntity.Id;
                    entity.Adresa = AdresaEntity;
                }
                else
                {
                    var AdresaEntity = _dbContext.Adrese.Find(entity.AdresaId);
                    AdresaEntity = _mapper.Map<Database.Adresa>(request.Adresa);
                }
            }

            _dbContext.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public async Task<Model.Korisnik> Login(string username, string password)
        {
            var entity = await _dbContext.Korisnici.Include("Uloge.Uloga").Include(x=>x.Uloge).FirstOrDefaultAsync(x => x.Username == username);

            if(entity == null)
            {
                throw new UserException("Pogrešan username ili password!");
            }

            var hash = GenerateHash(entity.PasswordSalt, password);
            if(hash!= entity.PasswordHash)
            {
                throw new UserException("Pogrešan username ili password!");
            }

            return _mapper.Map<Model.Korisnik>(entity);
        }
    }
}
