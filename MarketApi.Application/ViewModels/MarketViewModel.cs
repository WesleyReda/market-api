namespace MarketApi.Application.ViewModels
{
    public class MarketViewModel : EntityViewModel
    { 
        public string Description { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
