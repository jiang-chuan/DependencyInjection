using DependencyInjection.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NLog.Extensions.Logging;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hostBuilder = Host.CreateApplicationBuilder(args);

            hostBuilder.Services.AddSingleton<IProductRepository, ProductRepository>();
            hostBuilder.Services.AddSingleton<IProductService, ProductService>();

            hostBuilder.Logging.AddNLog();

            var host = hostBuilder.Build();

            var productService = host.Services.GetRequiredService<IProductService>();

            productService.GetProductList();
            productService.GetProductById(1);
            productService.GetProductById(2);
            productService.GetProductById(3);

            host.Run();
        }
    }
}
