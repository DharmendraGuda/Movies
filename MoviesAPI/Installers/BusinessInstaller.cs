using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoviesAPI.Business.Interfaces;
using MoviesAPI.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Installers
{
    public class BusinessInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IRatingRepository, RatingRepository>();
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddAutoMapper(typeof(Startup));
        }
    }
}
