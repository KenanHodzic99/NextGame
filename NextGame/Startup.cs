using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using NextGame.Filters;
using NextGame.Security;
using NextGame.Services;
using NextGame.Services.Adresa;
using NextGame.Services.Kontakt;
using NextGame.Services.ListaIgrica;

namespace NextGame
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(x =>
            {
                x.Filters.Add<ErrorFilters>();
                
            });

            services.AddAutoMapper(typeof(Startup));
            services.AddSwaggerGen(c=> 
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NextGame API", Version = "v1" });
                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type= ReferenceType.SecurityScheme, Id="basicAuth"}
                        },
                        new string[]{ }
                    }
                });
            });
            services.AddDbContext<NextGame.Database.NextGameDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("NextGame")));
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IIzdavackaKucaService, IzdavackaKucaService>();
            services.AddScoped<ISystemRequirementsService, SystemRequirementsService>();
            services.AddScoped<IListaIgricaService, ListaIgricaServis>();
            services.AddScoped<IUlogaService, UlogaService>();
            services.AddScoped<IAdresaService, AdresaService>();
            services.AddScoped<IKontaktService, KontaktService>();
            services.AddScoped<IIgricaService, IgricaService>();
            services.AddScoped<IKomentarService, KomentarService>();
            services.AddScoped<IObjavaService, ObjavaService>();
            services.AddScoped<IRecenzijaService, RecenzijaService>();
            services.AddScoped<IZanrService, ZanrService>();
            services.AddScoped<ITipService, TipService>();
            services.AddScoped<IPlatformaService, PlatformaService>();

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
