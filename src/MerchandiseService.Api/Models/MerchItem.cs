﻿namespace MerchandiseService.Api.Models
{
    public readonly struct MerchItem
    {
        public MerchItem(long itemId, string itemName)
        {
            ItemId = itemId;
            ItemName = itemName;
        }
        
        public long ItemId { get; }
        
        public string ItemName { get; }
    }
}