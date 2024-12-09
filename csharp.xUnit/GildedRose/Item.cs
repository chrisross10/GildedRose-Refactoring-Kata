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
            UpdateQuality(1);

            SellIn -= 1;

            if (SellIn < 0)
            {
                UpdateQuality(1);
            }
        }
        else
        {
            if (isBackstagePasses)
            {
                UpdateQuality(SellIn switch
                {
                    < 6 => 3,
                    < 11 => 2,
                    _ => 1
                });

                SellIn -= 1;

                if (SellIn < 0)
                {
                    Quality = 0;
                }
            }
            else
            {
                if (isNotSulfuras)
                {
                    UpdateQuality(-1);

                    SellIn -= 1;

                    if (SellIn < 0)
                    {
                        UpdateQuality(-1);
                    }
                }
            }
        }
    }

    private void UpdateQuality(int change)
    {
        Quality += change;
        Quality = Math.Clamp(Quality, 0, 50);
    }
}