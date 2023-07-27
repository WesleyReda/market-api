using MarketApi.Application.Interfaces;
using MarketApi.Application.ViewModels;
using MarketApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Application.AppServices
{
    public class ProductsAppService : BaseAppService, IProductsAppService
    {
        private readonly IProductsService _productsService;

        public ProductsAppService(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public IEnumerable<ProductViewModel> GetProducts()
        {
            var products = _productsService.GetProducts()
                .Select(p => new ProductViewModel
                {
                    CreatedAt = p.CreatedAt,
                    Description = p.Description,
                    Id = p.Id,
                    Price = p.Price
                });

            return products;
        }
    }
}
