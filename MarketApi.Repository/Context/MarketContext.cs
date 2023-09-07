using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketApi.Domain.Entities;

namespace MarketApi.Repository.Context
{
    public class MarketContext : DbContext
    {
        public DbSet<Market> Markets { get; set; }
    }
}
