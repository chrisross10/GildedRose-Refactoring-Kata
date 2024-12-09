using System;

namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void UpdateItem()
    {
        var isAgedBrie = Name == "Aged Brie";
        var isBackstagePasses = Name == "Backstage passes to a TAFKAL80ETC concert";
        var isSulfuras = Name == "Sulfuras, Hand of Ragnaros";

        if (isSulfuras)
        {
            UpdateSellInDays(0);
            return;
        }
        
        UpdateSellInDays(-1);
        
        if (isAgedBrie)
        {
            UpdateQuality(SellIn switch
            {
                < 0 => 2,
                _ => 1
            });

            return;
        }

        if (isBackstagePasses)
        {
            UpdateQuality(SellIn switch
            {
                < 0 => 0,
                < 5 => 3,
                < 10 => 2,
                _ => 1
            });

            return;
        }

        UpdateQuality(SellIn switch
        {
            < 0 => -2,
            _ => -1
        });
    }

    private void UpdateSellInDays(int days)
    {
        SellIn += days;
    }

    private void UpdateQuality(int change)
    {
        if (change == 0) Quality = 0;
        Quality += change;
        Quality = Math.Clamp(Quality, 0, 50);
    }
}