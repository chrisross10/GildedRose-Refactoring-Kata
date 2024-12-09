using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    private readonly List<IUpdatableItem> _updatableItems;

    public GildedRose(IList<Item> Items)
    {
        _updatableItems = new List<IUpdatableItem>();
        foreach (var item in Items)
        {
            _updatableItems.Add(new UpdatableItem(item));
        }
    }

    public void UpdateQuality()
    {
        foreach (var item in _updatableItems)
        {
            item.UpdateItem();
        }
    }
}