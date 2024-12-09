namespace GildedRoseKata;

public class UpdatableItem : IUpdatableItem
{
    private readonly Item _item;
    private readonly AgedBrieItem _agedBrieItem;
    private readonly BackstagePassesItem _backstagePassesItem;
    private readonly SulfurasItem _sulfurasItem;
    private readonly DefaultItem _defaultItem;

    public UpdatableItem(Item item)
    {
        _item = item;
        _agedBrieItem = new AgedBrieItem(item);
        _backstagePassesItem = new BackstagePassesItem(item);
        _sulfurasItem = new SulfurasItem(item);
        _defaultItem = new DefaultItem(item);
    }

    public void UpdateItem()
    {
        if (_item.Name == "Aged Brie")
        {
            _agedBrieItem.UpdateItem();

            return;
        }

        if (_item.Name == "Backstage passes to a TAFKAL80ETC concert")
        {
            _backstagePassesItem.UpdateItem();

            return;
        }

        if (_item.Name == "Sulfuras, Hand of Ragnaros")
        {
            _sulfurasItem.UpdateItem();
            
            return;
        }

        _defaultItem.UpdateItem();
    }

}