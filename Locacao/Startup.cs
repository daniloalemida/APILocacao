using Locacao.Domain.Interfaces;
using Locacao.Infra.Database;
using Locacao.Infra.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Locacao.Domain.Servicos;

namespace Locacao
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;

        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAgenciaRepositorio, AgenciaRepositorio>();
            services.AddScoped<ICheckListRepositorio, CheckListRepositorio>();
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IDevolucaoRepositorio, DevolucaoRepositorio>();
            services.AddScoped<IAluguelService, AluguelServico>();
            services.AddScoped<ICriptografarServico, CriptografarServico>();
            services.AddScoped<IOperadorRepositorio, OperadorRepositorio>();
            services.AddScoped<IMarcaVeiculoRepositorio, MarcaVeiculoRepositorio>();
            services.AddScoped<IModeloVeiculoRepositorio, ModeloVeiculoRepositorio>();
            services.AddScoped<IVeiculoRepositorio, VeiculoRepositorio>();
            services.AddScoped<IRetiradaVeiculoRepositorio, RetiradaVeiculoRepositorio>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAluguelRepositorio, AluguelRepositorio>();
            services.AddScoped<IAluguelService, AluguelServico>();            

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Locacao", Version = "v1" });
            });

            services.AddDbContext<EntityContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefautConection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Locacao v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
                

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        }
    }
}
