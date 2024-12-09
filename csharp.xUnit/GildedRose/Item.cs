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
        var isNotSulfuras = Name != "Sulfuras, Hand of Ragnaros";

        if (isAgedBrie)
        {
            SellIn -= 1;

            if (SellIn < 0)
            {
                UpdateQuality(2);
            }
            else
            {
                UpdateQuality(1);
            }

            return;
        }

        if (isBackstagePasses)
        {
            SellIn -= 1;
            
            if (SellIn < 0)
            {
                Quality = 0;
            }
            else
            {
                UpdateQuality(SellIn switch
                {
                    < 5 => 3,
                    < 10 => 2,
                    _ => 1
                });
            }

            return;
        }

        if (isNotSulfuras)
        {
            SellIn -= 1;

            if (SellIn < 0)
            {
                UpdateQuality(-2);
            }
            else
            {
                UpdateQuality(-1);
            }
        }
    }

    private void UpdateQuality(int change)
    {
        Quality += change;
        Quality = Math.Clamp(Quality, 0, 50);
    }
}