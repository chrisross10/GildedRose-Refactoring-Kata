namespace GildedRoseKata;

public class SulfurasItem(Item item) : UpdatableItem(item)
{
    public override void UpdateItem()
    {
        UpdateSellInDays(0);
    }
}