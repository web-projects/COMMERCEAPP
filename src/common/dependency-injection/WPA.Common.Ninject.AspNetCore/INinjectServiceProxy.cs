using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Ninject.Modules;

namespace WPA.Common.Ninject.AspNetCore
{
    public interface INinjectServiceProxy
    {
        void ConfigureServices(IServiceCollection services);
        void Configure(IApplicationBuilder app, params NinjectModule[] modules);
    }
}
