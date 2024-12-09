namespace GildedRoseKata;

public class SulfurasItem(Item item) : IUpdatableItem
{
    public void UpdateItem()
    {
        UpdateSellInDays(0);
    }
    
    private void UpdateSellInDays(int days)
    {
        item.SellIn += days;
    }
}