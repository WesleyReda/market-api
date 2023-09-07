using MarketApi.Domain.Entities;
using MarketApi.Domain.Services.Interfaces;
using MarketApi.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Domain.Services
{
    public class ProductsService : BaseService, IProductsService
    {
        private readonly IProductsRepository _productsRepository;
        public ProductsService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;

        }

        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>() {new Product(), new Product() };
        }
    }
}
