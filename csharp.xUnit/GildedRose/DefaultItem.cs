using System;

namespace GildedRoseKata;

public class DefaultItem : IUpdatableItem
{
    private Item _item;

    public DefaultItem(Item item)
    {
        _item = item;
    }

    public void UpdateItem()
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