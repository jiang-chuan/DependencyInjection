using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    internal class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository ProductRepository, ILogger<ProductService> Logger)
        {
            _productRepository = ProductRepository;
            _logger = Logger;
        }

        public void GetProduct()
        {
            _logger.Log(LogLevel.Information, "calling IProductRepository.IProductRepository()");
            _productRepository.GetProduct();
        }
    }
}
