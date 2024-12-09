using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly List<UpdatableItem> _updatableItems;
    private static readonly Dictionary<string, Func<Item, UpdatableItem>> ItemCreators = new()
    {
        { "Aged Brie", item => new AgedBrieItem(item) },
        { "Backstage passes to a TAFKAL80ETC concert", item => new BackstagePassesItem(item) },
        { "Sulfuras, Hand of Ragnaros", item => new SulfurasItem(item) }
    };

    public GildedRose(IList<Item> Items)
    {
        _updatableItems = new List<UpdatableItem>();
        foreach (var item in Items)
        {
            _updatableItems.Add(ItemCreators.TryGetValue(item.Name, out var creator)
                ? creator(item)
                : new DefaultItem(item));
        }
    }

    public void UpdateQuality()
    {
        foreach (var item in _updatableItems)
        {
            item.UpdateItem();
        }
    }
}