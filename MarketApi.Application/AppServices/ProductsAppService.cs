using MarketApi.Application.Interfaces;
using MarketApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Application.AppServices
{
    public class ProductsAppService : IProductsAppService
    {
        private readonly IProductsService _productsService;

        public ProductsAppService(IProductsService productsService)
        {
            _productsService = productsService;
        }
    }
}
