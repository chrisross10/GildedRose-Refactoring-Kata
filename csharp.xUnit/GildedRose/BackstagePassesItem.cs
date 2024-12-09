using System;

namespace GildedRoseKata;

public class BackstagePassesItem(Item item) : UpdatableItem(item)
{
    private readonly Item _item = item;

    public override void UpdateItem()
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
}