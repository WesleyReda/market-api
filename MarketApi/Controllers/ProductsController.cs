using MarketApi.Application.Interfaces;
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
        public IActionResult GetProducts()
        {
            return Ok();
        }
    }
}
