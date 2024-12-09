using System;

namespace GildedRoseKata;

public abstract class UpdatableItem(Item item)
{
    public abstract void UpdateItem();
    
    protected void UpdateSellInDays(int days)
    {
        item.SellIn += days;
    }

    protected void UpdateQuality(int change)
    {
        if (change == 0) item.Quality = 0;
        item.Quality += change;
        item.Quality = Math.Clamp(item.Quality, 0, 50);
    }
}