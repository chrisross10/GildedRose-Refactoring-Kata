using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly List<UpdatableItem> _updatableItems;

    public GildedRose(IList<Item> Items)
    {
        _updatableItems = new List<UpdatableItem>();
        foreach (var item in Items)
        {
            _updatableItems.Add(item.Name switch
            {
                "Aged Brie" => new AgedBrieItem(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassesItem(item),
                "Sulfuras, Hand of Ragnaros" => new SulfurasItem(item),
                _ => new DefaultItem(item)
            });
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