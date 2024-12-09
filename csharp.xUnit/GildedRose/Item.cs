namespace GildedRoseKata;

public class Item
{
    private readonly UpdateableItem _updateableItem;

    public Item()
    {
        _updateableItem = new UpdateableItem(this);
    }

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public UpdateableItem UpdateableItem => _updateableItem;
}