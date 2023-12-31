﻿using MarketApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Domain.Services.Interfaces
{
    public interface IMarketsService
    {
        IEnumerable<Market> GetMarkets();
    }
}
