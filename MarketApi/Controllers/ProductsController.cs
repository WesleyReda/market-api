using MarketApi.Application.Interfaces;
using MarketApi.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MarketApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public readonly IProductsAppService _productsService;

        public ProductsController(IProductsAppService productService)
        {
            _productsService = productService;
        }


        [HttpGet]
        public IEnumerable<ProductViewModel> GetProducts()
        {
            return _productsService.GetProducts();
        }
    }
}
