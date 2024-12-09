using System;

namespace GildedRoseKata;

public class DefaultItem(Item item) : UpdatableItem(item)
{
    private readonly Item _item = item;

    public override void UpdateItem()
    {
        UpdateSellInDays(-1);
        UpdateQuality(_item.SellIn switch
        {
            < 0 => -2,
            _ => -1
        });
    }
}