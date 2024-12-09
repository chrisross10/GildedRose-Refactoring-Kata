﻿using System;

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

        if (isSulfuras) return;
        
        DecreaseSellInDays();
        
        if (isAgedBrie)
        {
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

        if (SellIn < 0)
        {
            UpdateQuality(-2);
        }
        else
        {
            UpdateQuality(-1);
        }
    }

    private void DecreaseSellInDays()
    {
        SellIn -= 1;
    }

    private void UpdateQuality(int change)
    {
        Quality += change;
        Quality = Math.Clamp(Quality, 0, 50);
    }
}