using MarketApi.Application.Interfaces;
using MarketApi.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MarketApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarketsController : ControllerBase
    {
        public readonly IMarketsAppService _marketsService;

        public MarketsController(IMarketsAppService marketsService)
        {
            _marketsService = marketsService;
        }


        [HttpGet]
        public IEnumerable<MarketViewModel> GetMarkets()
        {
            return _marketsService.GetMarkets();
        }
    }
}
