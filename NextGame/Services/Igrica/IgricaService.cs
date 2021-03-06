using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NextGame.Database;
using NextGame.Model.Requests.Igrica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
//using NextGame.Migrations;

namespace NextGame.Services
{
    public class IgricaService :
        BaseCRUDService<Model.Igrica, Database.Igrica, IgricaSearchRequest, IgricaInsertRequest, IgricaUpdateRequest>,
        IIgricaService
    {
        public IgricaService(NextGameDBContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {

        }

        public override IEnumerable<Model.Igrica> GetAll(IgricaSearchRequest search = null)
        {
            var entity = _dbContext.Set<Igrica>().Include(x => x.IzdavackaKuca).Include(x => x.SystemRequirements).Include(x => x.Zanrovi).Include(x => x.Tip).Include(x => x.Platforme)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }

            if (search.Cijena.HasValue)
            {
                entity = entity.Where(x => x.Cijena == search.Cijena);
            }

            if (!string.IsNullOrWhiteSpace(search?.IzdavackaKuca))
            {
                entity = entity.Where(x => x.IzdavackaKuca.Naziv == search.IzdavackaKuca);
            }

            if (search.GodinaIzdavanja.HasValue)
            {
                entity = entity.Where(x => x.DatumIzdavanja.Year == search.GodinaIzdavanja);
            }

            if (!string.IsNullOrWhiteSpace(search?.Tip))
            {
                entity = entity.Where(x => x.Tip.Naziv.Contains(search.Tip));
            }

            if (!string.IsNullOrWhiteSpace(search?.Zanr))
            {
                var zanr = _dbContext.Zanrovi.Where(x => x.Naziv.Contains(search.Zanr)).SingleOrDefault();
                if (zanr != null)
                    entity = entity.Where(x => x.Zanrovi.Where(x => x.ZanrId == zanr.Id).ToList().Count > 0);
                else
                    entity = entity.Where(x => x.Cijena == -10);
            }

            if (!string.IsNullOrWhiteSpace(search?.Platforma))
            {
                var platforma = _dbContext.Platforme.Where(x => x.Naziv.Contains(search.Platforma)).SingleOrDefault();
                if (platforma != null)
                    entity = entity.Where(x => x.Platforme.Where(x => x.PlatformaId == platforma.Id).ToList().Count > 0);
                else
                    entity = entity.Where(x => x.Cijena == -10);
            }

            if (search.Ocjena.HasValue)
            {
                entity = entity.Where(x => x.Ocjena == search.Ocjena);
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Igrica>>(list);
        }

        public override Model.Igrica Insert(IgricaInsertRequest request)
        {
            var setIgrica = _dbContext.Set<Igrica>();
            var setSysReq = _dbContext.Set<SystemRequirements>();
            var setPlatforma = _dbContext.Set<IgricaPlatforma>();
            var setZanr = _dbContext.Set<IgricaZanr>();

            var entity = _mapper.Map<Igrica>(request);

            entity.IzdavackaKucaId = request.IzdavackaKucaId;
            entity.IzdavackaKuca = _dbContext.IzdavackeKuce.Find(request.IzdavackaKucaId);

            var sysReq = _mapper.Map<SystemRequirements>(request.SystemRequirements);
            setSysReq.Add(sysReq);

            entity.SystemRequirementsId = sysReq.Id;
            entity.SystemRequirements = sysReq;

            entity.Tip = _mapper.Map<Tip>(request.Tip);

            foreach (var zanr in request.ZanroviId)
            {
                var igricaZanr = new IgricaZanr()
                {
                    IgricaId = entity.Id,
                    ZanrId = zanr
                };
                setZanr.Add(igricaZanr);
                entity.Zanrovi.Add(igricaZanr);
            }

            foreach (var platforma in request.PlatformeId)
            {
                var igricaPlatforma = new IgricaPlatforma()
                {
                    IgricaId = entity.Id,
                    PlatformaId = platforma,
                };
                setPlatforma.Add(igricaPlatforma);
                entity.Platforme.Add(igricaPlatforma);
            }

            setIgrica.Add(entity);
            _dbContext.SaveChanges();
            return _mapper.Map<Model.Igrica>(entity);
        }


        public override Model.Igrica Update(int id, IgricaUpdateRequest request)
        {
            var entity = _dbContext.Igrice.Find(id);

            var entityZanrovi = _dbContext.IgriceZanrovi.Where(x => x.IgricaId == entity.Id);
            var remove = new List<IgricaZanr>();
            foreach (var entityZanr in entityZanrovi)
            {
                bool removeZanr = false;
                foreach (var zanrid in request.ZanroviId)
                {
                    if(entityZanr.ZanrId == zanrid)
                    {
                        removeZanr = false;
                        break;
                    }
                    removeZanr = true;
                }
                if (removeZanr)
                {
                    remove.Add(entityZanr);
                }
            }
            foreach(var toRemove in remove)
            {
                entity.Zanrovi.Remove(toRemove);
            }
            _dbContext.IgriceZanrovi.RemoveRange(remove);

            var entityPlatforme = _dbContext.IgricePlatforme.Where(x => x.IgricaId == entity.Id);
            var removePlatorme = new List<IgricaPlatforma>();
            foreach (var entityPlatforma in entityPlatforme)
            {
                bool removePlatforma = false;
                foreach (var platformaId in request.PlatformeId)
                {
                    if (entityPlatforma.PlatformaId == platformaId)
                    {
                        removePlatforma = false;
                        break;
                    }
                    removePlatforma = true;
                }
                if (removePlatforma)
                {
                    removePlatorme.Add(entityPlatforma);
                }
            }
            foreach (var toRemove in removePlatorme)
            {
                entity.Platforme.Remove(toRemove);
            }
            _dbContext.IgricePlatforme.RemoveRange(removePlatorme);


            _mapper.Map(request, entity);

            entity.IzdavackaKucaId = request.IzdavackaKucaId;
            entity.IzdavackaKuca = _dbContext.IzdavackeKuce.Find(request.IzdavackaKucaId);

            var sysReqentity = _dbContext.SystemRequirements.Find(entity.SystemRequirementsId);
            sysReqentity = _mapper.Map<SystemRequirements>(request.SystemRequirements);

            entity.Tip = _mapper.Map<Tip>(request.Tip);

            foreach (var zanr in request.ZanroviId)
            {
                var igricaZanr = _dbContext.IgriceZanrovi.Find(entity.Id, zanr);
                if(igricaZanr == null)
                {
                    var newEntry = new IgricaZanr() { IgricaId = entity.Id, ZanrId = zanr };
                    _dbContext.IgriceZanrovi.Add(newEntry);
                    entity.Zanrovi.Add(newEntry);
                }
            }

            foreach (var platforma in request.PlatformeId)
            {
                var igricaPlatforma = _dbContext.IgricePlatforme.Find(entity.Id, platforma);
                if (igricaPlatforma == null)
                {
                    var newEntry = new IgricaPlatforma() { IgricaId = entity.Id, PlatformaId = platforma };
                    _dbContext.IgricePlatforme.Add(newEntry);
                    entity.Platforme.Add(newEntry);
                }
            }

            _dbContext.SaveChanges();
            return _mapper.Map<Model.Igrica>(entity);
        }

        private static MLContext mlContext = null;
        private static ITransformer model = null;

        public List<Model.Igrica> Recomend(int id)
        {
            if (mlContext == null)
            {
                mlContext = new MLContext();
                var tempKorisnici = _dbContext.Korisnici.ToList();
                var data = new List<ProductEntry>();
                foreach (var user in tempKorisnici)
                {
                    var tempData = _dbContext.ListaIgrica.Include(x => x.Igrica).Include(x => x.Igrica.IzdavackaKuca)
                        .Include(x => x.Korisnik).Include(x => x.Igrica.SystemRequirements).Include(x => x.Igrica.Tip).Include(x=>x.Igrica.Platforme).Include(x=>x.Igrica.Zanrovi)
                        .Where(x => x.Korisnik.Id == user.Id).ToList();

                    foreach (var x in tempData)
                    {
                        if (tempData.Count > 1)
                        {
                            var distinctItemId = tempData.Select(y => y.IgricaId).ToList();
                            distinctItemId.ForEach(y =>
                            {
                                var relatedItems = tempData.Where(z => z.IgricaId != y).ToList();

                                foreach (var z in relatedItems)
                                {
                                    data.Add(new ProductEntry()
                                    {
                                        ProductID = (uint)y,
                                        CopurchaseProductID = (uint)z.IgricaId
                                    });
                                }
                            });
                        }   
                    }
                }

                var traindata = mlContext.Data.LoadFromEnumerable(data);

                MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
                options.MatrixRowIndexColumnName = nameof(ProductEntry.CopurchaseProductID);
                options.LabelColumnName = "Label";
                options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                options.Alpha = 0.01;
                options.Lambda = 0.025;
                options.NumberOfIterations = 100;
                options.C = 0.00001;

                var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);
                if (traindata.GetRowCount() < 1)
                {
                    return new List<Model.Igrica>();
                }
                model = est.Fit(traindata);
            }

            var allItems = _dbContext.Igrice.Include(x => x.IzdavackaKuca)
                .Include(x => x.SystemRequirements).Include(x => x.Tip).Include(x => x.Platforme).Include(x => x.Zanrovi)
                       .Where(x => x.Id != id);

            var predictionResult = new List<Tuple<Database.Igrica, float>>();

            foreach (var item in allItems)
            {
                var predictionEngine =
                    mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
                var prediction = predictionEngine.Predict(new ProductEntry()
                {
                    ProductID = (uint)id,
                    CopurchaseProductID = (uint)item.Id
                });

                predictionResult.Add(new Tuple<Igrica, float>(item,prediction.Score));
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2)
                .Select(x => x.Item1).Take(4);

            var excess = finalResult.Where(x => x.Id == id).SingleOrDefault();

            finalResult.ToList().Remove(excess);

            return _mapper.Map<List<Model.Igrica>>(finalResult);
        }
    }

    public class Copurchase_prediction
    {
        public float Score { get; set; }
    }

    public class ProductEntry
    {
        [KeyType(count:10)]
        public uint ProductID { get; set; }
        [KeyType(count:10)]
        public  uint CopurchaseProductID { get; set; }

        public float Label { get; set; }
    }
}
