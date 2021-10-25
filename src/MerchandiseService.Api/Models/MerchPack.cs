using System.Collections.Generic;

namespace MerchandiseService.Api.Models
{
    public class MerchPack
    {
        public MerchPack(List<MerchItem> items)
        {
            
            Items = items;
        }
        public List<MerchItem> Items { get; }
    }
}