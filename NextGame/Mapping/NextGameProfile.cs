using AutoMapper;
using NextGame.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGame.Mapping
{
    public class NextGameProfile : Profile
    {
        public NextGameProfile()
        {
            CreateMap<Korisnik, Model.Korisnik>().ReverseMap();
            CreateMap<Korisnik, Model.Requests.Korisnik.KorisnikInsertRequest>().ReverseMap();
            CreateMap<Korisnik, Model.Requests.Korisnik.KorisnikUpdateRequest>().ReverseMap();

            CreateMap<Kontakt, Model.Kontakt>().ReverseMap();
            CreateMap<Kontakt, Model.Requests.Kontakt.KontaktInsertRequest>().ReverseMap();
            CreateMap<Kontakt, Model.Requests.Kontakt.KontaktUpdateRequest>().ReverseMap();

            CreateMap<Adresa, Model.Adresa>().ReverseMap();
            CreateMap<Adresa, Model.Requests.Adresa.AdresaInsertRequest>().ReverseMap();
            CreateMap<Adresa, Model.Requests.Adresa.AdresaUpdateRequest>().ReverseMap();

            CreateMap<IzdavackaKuca, Model.IzdavackaKuca>().ReverseMap();
            CreateMap<IzdavackaKuca, Model.Requests.IzdavackaKuca.IzdavackaKucaInsertRequest>().ReverseMap();
            CreateMap<IzdavackaKuca, Model.Requests.IzdavackaKuca.IzdavackaKucaUpdateRequest>().ReverseMap();

            CreateMap<SystemRequirements, Model.SystemRequirements>().ReverseMap();
            CreateMap<SystemRequirements, Model.Requests.SystemRequirements.SystemRequirementsInsertRequest>().ReverseMap();
            CreateMap<SystemRequirements, Model.Requests.SystemRequirements.SystemRequirementsUpdateRequest>().ReverseMap();

            CreateMap<ListaIgrica, Model.ListaIgrica>().ReverseMap();
            CreateMap<ListaIgrica, Model.Requests.ListaIgrica.ListaIgricaInsertRequest>().ReverseMap();
            CreateMap<ListaIgrica, Model.Requests.ListaIgrica.ListaIgricaUpdateRequest>().ReverseMap();

            CreateMap<Uloga, Model.Uloga>().ReverseMap();
            CreateMap<Uloga, Model.Requests.UlogaIZanr.UlogaInsertRequest>().ReverseMap();
            CreateMap<Uloga, Model.Requests.UlogaIZanr.UlogaUpdateRequest>().ReverseMap();

            CreateMap<Zanr, Model.Zanr>().ReverseMap();
            CreateMap<Zanr, Model.Requests.UlogaIZanr.UlogaInsertRequest>().ReverseMap();
            CreateMap<Zanr, Model.Requests.UlogaIZanr.UlogaUpdateRequest>().ReverseMap();

            CreateMap<Tip, Model.Tip>().ReverseMap();
            CreateMap<Tip, Model.Requests.UlogaIZanr.UlogaInsertRequest>().ReverseMap();
            CreateMap<Tip, Model.Requests.UlogaIZanr.UlogaUpdateRequest>().ReverseMap();

            CreateMap<Platforma, Model.Platforma>().ReverseMap();
            CreateMap<Platforma, Model.Requests.UlogaIZanr.UlogaInsertRequest>().ReverseMap();
            CreateMap<Platforma, Model.Requests.UlogaIZanr.UlogaUpdateRequest>().ReverseMap();

            CreateMap<Igrica, Model.Igrica>().ReverseMap();
            CreateMap<Igrica, Model.Requests.Igrica.IgricaInsertRequest>().ReverseMap();
            CreateMap<Igrica, Model.Requests.Igrica.IgricaUpdateRequest>().ReverseMap();

            CreateMap<Komentar, Model.Komentar>().ReverseMap();
            CreateMap<Komentar, Model.Requests.Komentar.KomentarInsertRequest>().ReverseMap();
            CreateMap<Komentar, Model.Requests.Komentar.KomentarUpdateRequest>().ReverseMap();

            CreateMap<Objava, Model.Objava>().ReverseMap();
            CreateMap<Objava, Model.Requests.Objava.ObjavaInsertRequest>().ReverseMap();
            CreateMap<Objava, Model.Requests.Objava.ObjavaUpdateRequest>().ReverseMap();

            CreateMap<Recenzija, Model.Recenzija>().ReverseMap();
            CreateMap<Recenzija, Model.Requests.Recenzija.RecenzijaInsertRequest>().ReverseMap();
            CreateMap<Recenzija, Model.Requests.Recenzija.RecenzijaUpdateRequest>().ReverseMap();

            CreateMap<KorisniciUloge, Model.KorisniciUloge>().ReverseMap();
        }
    }
}
