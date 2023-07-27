using MarketApi.Application.Interfaces;
using MarketApi.Application.ViewModels;
using MarketApi.Domain.Interfaces;

namespace MarketApi.Application.AppServices
{
    public class MarketsAppService : BaseAppService, IMarketsAppService
    {
        private readonly IMarketsService _marketsService;

        public MarketsAppService(IMarketsService marketsService)
        {
            _marketsService = marketsService;
        }

        public IEnumerable<MarketViewModel> GetMarkets()
        {
            var markets = _marketsService.GetMarkets()
                .Select(p => new MarketViewModel
                {
                    CreatedAt = p.CreatedAt,
                    Description = p.Description,
                    Id = p.Id
                });

            return markets;
        }
    }
}
