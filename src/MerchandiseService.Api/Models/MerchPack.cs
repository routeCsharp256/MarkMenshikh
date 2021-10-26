using System.Collections.Generic;

namespace MerchandiseService.Api.Models
{
    public readonly struct MerchPack
    {
        public MerchPack(List<MerchItem> items)
        {
            
            Items = items;
        }
        public List<MerchItem> Items { get; }
    }
}