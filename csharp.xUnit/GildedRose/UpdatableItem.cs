using System;

namespace GildedRoseKata;

public class UpdatableItem : IUpdatableItem
{
    private Item _item;

    public UpdatableItem(Item item)
    {
        _item = item;
    }

    public void UpdateItem()
    {
        if (_item.Name == "Aged Brie")
        {
            UpdateAgedBrie();

            return;
        }

        if (_item.Name == "Backstage passes to a TAFKAL80ETC concert")
        {
            UpdateBackstagePasses();

            return;
        }

        if (_item.Name == "Sulfuras, Hand of Ragnaros")
        {
            UpdateSulfuras();
            
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

    private void UpdateBackstagePasses()
    {
        UpdateSellInDays(-1);
        UpdateQuality(_item.SellIn switch
        {
            < 0 => 0,
            < 5 => 3,
            < 10 => 2,
            _ => 1
        });
    }

    private void UpdateAgedBrie()
    {
        UpdateSellInDays(-1);
        UpdateQuality(_item.SellIn switch
        {
            < 0 => 2,
            _ => 1
        });
    }

    private void UpdateSulfuras()
    {
        UpdateSellInDays(0);
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