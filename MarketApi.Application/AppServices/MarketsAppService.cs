using AutoMapper;
using MarketApi.Application.Interfaces;
using MarketApi.Application.ViewModels;
using MarketApi.Domain.Interfaces;

namespace MarketApi.Application.AppServices
{
    public class MarketsAppService : BaseAppService, IMarketsAppService
    {
        private readonly IMarketsService _marketsService;

        private readonly IMapper _mapper;

        public MarketsAppService(IMarketsService marketsService, IMapper mapper)
        {
            _marketsService = marketsService;
            _mapper = mapper;
        }

        public IEnumerable<MarketViewModel> GetMarkets()
        {
            var markets = _marketsService.GetMarkets();

            return _mapper.Map<IEnumerable<MarketViewModel>>(markets);
        }
    }
}
