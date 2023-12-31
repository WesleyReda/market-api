﻿using MarketApi.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Application.Interfaces
{
    public interface IProductsAppService
    {
        IEnumerable<ProductViewModel> GetProducts();
    }
}
