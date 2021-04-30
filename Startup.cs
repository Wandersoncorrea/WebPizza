using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

using Microsoft.Extensions.Options;

using WebPizza.Dominio.DAOs;
using WebPizza.Dominio.DAOs.Interfaces;
using WebPizza.Dominio.Repositorios;
using WebPizza.Dominio.Services;
using WebPizza.Dominio.Services.Interfaces;
using WebPizza.Dominio.Services.Classes;
using WebPizza.Dominio.Repositorios.Classes;
using WebPizza.obj.Dominio.DAOs.Interfaces;


namespace WebPizza
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
            // Aqui que vamos fazer a instancia dos objetos para trabalhar
            // de forma com injecão de dependencias.
           services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddCors();
            
            var connectionString = @"Data Source=DESKTOP-BFGEAHA\SQLEXPRESS03;
                                     Initial Catalog=PizzariaApi;
                                     User Id=sa;
                                     Password=123456;";

            IClienteDAO clienteDAO = new ClienteDAO(connectionString);
            var repositorioCliente = new ClienteRepositorio(clienteDAO);
            var servicoCliente = new ClienteService(repositorioCliente);

            IPizzaDAO pizzaDAO = new PizzaDAO(connectionString);
            var repositorioPizza = new PizzaRepositorio(pizzaDAO);
            var servicoPizza = new PizzaService(repositorioPizza);

            IPedidoDAO pedidoDAO = new PedidoDAO(connectionString);
            var repositorioPedido = new PedidoRepositorio(pedidoDAO);
            var servicoPedido = new PedidoService(repositorioPedido);

            IBebidaDAO bebidaDAO = new BebidaDAO(connectionString);
            var repositorioBebida = new BebidaRepositorio(bebidaDAO);
            var servicoBebida = new BebidaService(repositorioBebida);
          
            IEnderecoDAO enderecoDAO = new EnderecoDAO(connectionString);
            var repositorioEndereco = new EnderecoRepositorio(enderecoDAO);
            var servicoEndereco = new EnderecoService(repositorioEndereco);
             
            //Para cada servico
            services.AddSingleton<IBebidaService>(servicoBebida);
            services.AddSingleton<IPedidoService>(servicoPedido);
            services.AddSingleton<IClienteService>(servicoCliente);
            services.AddSingleton<IEnderecoService>(servicoEndereco);
            services.AddSingleton<IPizzaService>(servicoPizza);
            

        }
       
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            
        }
 

        // public void ConfigureServices(IServiceCollection services)
        // {

        //     services.AddControllers();
        //     services.AddSwaggerGen(c =>
        //     {
        //         c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebPizza", Version = "v1" });
        //     });
        // }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        // {
        //     if (env.IsDevelopment())
        //     {
        //         app.UseDeveloperExceptionPage();
        //         app.UseSwagger();
        //         app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebPizza v1"));
        //     }

        //     app.UseHttpsRedirection();

        //     app.UseRouting();

        //     app.UseAuthorization();

        //     app.UseEndpoints(endpoints =>
        //     {
        //         endpoints.MapControllers();
        //     });
        // }

    }
}
