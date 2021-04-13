using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ProjetoMedico.BFF.Adapter;
using ProjetoMedico.BFF.Bordas___Interfaces.UseCases.Repositorio;
using ProjetoMedico.BFF.Bordas_Interfaces.Adapter;
using ProjetoMedico.BFF.Bordas_Interfaces.UseCases;
using ProjetoMedico.BFF.Repositorios;
using ProjetoMedico.BFF.UseCase.Medico;

namespace ProjetoMedico.BFF
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



            #region Implementação de Interfaces de Medico

            services.AddScoped<IRepositorioMedicos, RepositorioMedicos>();

            services.AddScoped<IAdicionarMedicoUseCase, AdicionarMedicoUseCase>();
            services.AddScoped<IAtualizarMedicoUseCases, AtualizarMedicoUseCases>();
            services.AddScoped<IDeletarMedicoUseCase, DeletarMedicoUseCase>();
            services.AddScoped<IRetornarListaMedicosUseCase, RetornarListaMedicosUseCase>();
            services.AddScoped<IRetornarMedicoIdUseCase, RetornarMedicoIdUseCase>();

            services.AddTransient<IAdicionarMedicoAdapter, AdicionarMedicoAdapter>();
            services.AddTransient<IAtualizarMedicoAdapter, AtualizarMedicoAdapter>();
            services.AddTransient<IRetornarMedicoIdAdapter, RetornarMedicoIdAdapter>();



            #endregion


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjetoMedico.BFF", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjetoMedico.BFF v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
