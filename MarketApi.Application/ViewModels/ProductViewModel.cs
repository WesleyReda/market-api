﻿namespace MarketApi.Application.ViewModels
{
    public class ProductViewModel : EntityViewModel
    { 
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
