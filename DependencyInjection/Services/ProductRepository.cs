using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    internal class ProductRepository : IProductRepository
    {
        private readonly ILogger<ProductRepository> _logger;

        public ProductRepository(ILogger<ProductRepository> Logger)
        {
            _logger = Logger;
        }

        public void GetProductById(int id)
        {
            _logger.Log(LogLevel.Information, $"fetch product {id} from the db");
        }

        public void GetProductList()
        {
            _logger.Log(LogLevel.Information, "fetch product list from the db");
        }
    }
}
