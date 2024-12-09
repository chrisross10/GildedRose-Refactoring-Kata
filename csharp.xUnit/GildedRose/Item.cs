namespace GildedRoseKata;

public class Item
{
    private readonly UpdatableItem _updatableItem;

    public Item()
    {
        _updatableItem = new UpdatableItem(this);
    }

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public UpdatableItem UpdatableItem => _updatableItem;
}