using System;

namespace GildedRoseKata;

public class UpdatableItem : IUpdatableItem
{
    private readonly Item _item;
    private readonly AgedBrieItem _agedBrieItem;
    private readonly BackstagePassesItem _backstagePassesItem;
    private readonly SulfurasItem _sulfurasItem;

    public UpdatableItem(Item item)
    {
        _item = item;
        _agedBrieItem = new AgedBrieItem(item);
        _backstagePassesItem = new BackstagePassesItem(item);
        _sulfurasItem = new SulfurasItem(item);
    }

    public void UpdateItem()
    {
        if (_item.Name == "Aged Brie")
        {
            _agedBrieItem.UpdateItem();

            return;
        }

        if (_item.Name == "Backstage passes to a TAFKAL80ETC concert")
        {
            _backstagePassesItem.UpdateItem();

            return;
        }

        if (_item.Name == "Sulfuras, Hand of Ragnaros")
        {
            _sulfurasItem.UpdateItem();
            
            return;
        }

        UpdateDefaultItem();
    }

    private void UpdateDefaultItem()
    {
        UpdateSellInDays(-1);
        UpdateQuality(_item.SellIn switch
        {
            < 0 => -2,
            _ => -1
        });
    }

    private void UpdateSellInDays(int days)
    {
        _item.SellIn += days;
    }

    private void UpdateQuality(int change)
    {
        if (change == 0) _item.Quality = 0;
        _item.Quality += change;
        _item.Quality = Math.Clamp(_item.Quality, 0, 50);
    }
}