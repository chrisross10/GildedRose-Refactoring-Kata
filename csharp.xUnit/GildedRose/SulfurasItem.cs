namespace GildedRoseKata;

public class SulfurasItem : IUpdatableItem
{
    private Item _item;

    public SulfurasItem(Item item)
    {
        _item = item;
    }

    public void UpdateItem()
    {
        UpdateSellInDays(0);
    }
    
    private void UpdateSellInDays(int days)
    {
        _item.SellIn += days;
    }
}