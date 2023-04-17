using System.Diagnostics;

using Core.Utilities.IoC;

using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers
{
    public class CoreModule:ICoreModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
            

        }
    }
}
