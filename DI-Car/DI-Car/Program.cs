using DI_Car.Abstractions;
using DI_Car.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DI_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DI setup

                HostApplicationBuilder hostApplicationBuilder = Host.CreateApplicationBuilder(args);

                hostApplicationBuilder.Services.AddSingleton<ICar, Car>();
                hostApplicationBuilder.Services.AddSingleton<IEngine, Engine1>();

                using IHost host = hostApplicationBuilder.Build();

                using IServiceScope serviceScope = host.Services.CreateScope();
                IServiceProvider diProvider = serviceScope.ServiceProvider;

            #endregion

            var packagesVersionsDeserializer = diProvider.GetService<ICar>();
            var packagesVersionsDeserializer = diProvider.GetService<ICar>();
        }
    }
}