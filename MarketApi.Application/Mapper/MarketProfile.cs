using AutoMapper;
using MarketApi.Application.ViewModels;
using MarketApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Application.Mapper
{
    public class MarketProfile : Profile
    {
        public MarketProfile() {
            CreateMap<Market, MarketViewModel>();
        }
    }
}
