using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Installers
{
    public static class InstallerExtensions
    {
        public static void InstallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var calssesImplementIInstalle = typeof(Startup).Assembly.ExportedTypes.Where(x => typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                       .ToList();
            var instllers = calssesImplementIInstalle.Select(Activator.CreateInstance).Cast<IInstaller>().ToList();
            instllers.ForEach(installer => installer.InstallServices(services, configuration));
        }
    }
}
