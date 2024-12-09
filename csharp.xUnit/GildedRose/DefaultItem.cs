using System;

namespace GildedRoseKata;

public class DefaultItem(Item item) : IUpdatableItem
{
    public void UpdateItem()
    {
        UpdateSellInDays(-1);
        UpdateQuality(item.SellIn switch
        {
            < 0 => -2,
            _ => -1
        });
    }
    
    private void UpdateSellInDays(int days)
    {
        item.SellIn += days;
    }

    private void UpdateQuality(int change)
    {
        if (change == 0) item.Quality = 0;
        item.Quality += change;
        item.Quality = Math.Clamp(item.Quality, 0, 50);
    }
}