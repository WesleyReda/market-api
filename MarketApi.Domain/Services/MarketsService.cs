﻿using MarketApi.Domain.Entities;
using MarketApi.Domain.Services.Interfaces;
using MarketApi.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Domain.Services
{
    public class MarketsService : BaseService, IMarketsService
    {
        private readonly IMarketsRepository _marketsRepository;
        public MarketsService(IMarketsRepository marketsRepository)
        {
            _marketsRepository = marketsRepository;

        }

        public IEnumerable<Market> GetMarkets()
        {
            return _marketsRepository.GetMarkets();
        }
    }
}
