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

        public void GetProductById(int id)
        {
            _logger.Log(LogLevel.Information, "calling IProductRepository.GetProductById()");
            _productRepository.GetProductById(id);
        }

        public void GetProductList()
        {
            _logger.Log(LogLevel.Information, "calling IProductRepository.GetProductList()");
            _productRepository.GetProductList();
        }
    }
}
