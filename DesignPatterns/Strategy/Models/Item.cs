﻿using StrategyPattern.Enums;

namespace StrategyPattern.Models
{
    public class Item
    {
        public string Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public ItemType ItemType { get; }

        public Item(string id, string name, decimal price, ItemType type)
        {
            Id = id;
            Name = name;
            Price = price;
            ItemType = type;
        }
    }
}