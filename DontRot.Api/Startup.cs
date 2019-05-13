using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using DontRot.Bll.Services;
using DontRot.DAL;
using DontRot.Bll;

namespace DontRot.Api
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
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(
                    json => json.SerializerSettings.ReferenceLoopHandling 
                            = ReferenceLoopHandling.Ignore);

            services.AddDbContext<DontRotContext>(o =>
                o.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"])
                .ConfigureWarnings(c => c.Throw(RelationalEventId.QueryClientEvaluationWarning)));

            services.AddTransient<IFoodService, FoodService>();

            services.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<DAL.Entities.Food, Bll.Dtos.Food>()
                    .AfterMap((f, dto, ctx) => {
                        dto.CategoryName = f.Category.Name;
                        dto.SlotName = f.Slot.Name;
                        dto.StorageName = f.Slot.Storage.Name;
                    }).ReverseMap();
            });

            services.AddSwaggerDocument();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUi3();

            //app.UseProblemDetails();
            app.UseMvc();
        }
    }
}
