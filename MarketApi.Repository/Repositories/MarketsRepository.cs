using MarketApi.Domain.Entities;
using MarketApi.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Repository.Repositories
{
    public class MarketsRepository : BaseRepository, IMarketsRepository
    {

        public MarketsRepository()
        {

        }
        public IEnumerable<Market> GetMarkets()
        {
            return new List<Market>() { new Market(), new Market() };
        }
    }
}
