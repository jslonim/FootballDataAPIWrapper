﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FootballDataWrapper.Business;
using FootballDataWrapper.Business.Interfaces;
using FootballDataWrapper.Data;
using FootballDataWrapper.Data.Contexts;
using FootballDataWrapper.Data.Interfaces;
using FootballDataWrapper.Data.Interfaces.Utilities;
using FootballDataWrapper.Data.Utilities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace FootballDataWrapper
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
            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Football API Wrapper", Version = "v1" });
            });

            //Services
            services.AddScoped<ILeagueService, LeagueService>();
            services.AddScoped<IPlayersService, PlayersService>();

            services.AddScoped<IApiKey, ApiKey>(
                s => new ApiKey(Configuration["Application:ApiKey"].ToString())
            );

            services.AddDbContext<FootballDataContext>
                (options => options.UseSqlServer(Configuration["Application:FootBallBD_ConnectionString"].ToString())
            );

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
